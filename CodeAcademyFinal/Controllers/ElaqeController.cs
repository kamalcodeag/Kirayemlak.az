using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class ElaqeController : Controller
    {
        private readonly RentEstateDb _context;

        public ElaqeController(RentEstateDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Contact = "Contact";

            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Message messageModel)
        {
            ViewBag.Contact = "Contact";

            if(!ModelState.IsValid)
            {
                ViewBag.Contact = "Contact";
                return View(messageModel);
            }

            Message message = new Message
            {
                FullName = messageModel.FullName.Trim(),
                Email = messageModel.Email.Trim(),
                PhoneNumber = messageModel.PhoneNumber.Trim(),
                Subject = messageModel.Subject.Trim(),
                MessageText = messageModel.MessageText.Trim(),
                SentTime = DateTime.Now
            };

            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            TempData["MessageSent"] = true;

            return View();
        }
    }
}