using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GelenmektublarController : Controller
    {
        private readonly RentEstateDb _context;

        public GelenmektublarController(RentEstateDb context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Siyahi()
        {
            ViewBag.Messages = "Messages";
            ViewBag.AllMessages = Convert.ToDecimal(_context.Messages.Count());

            IQueryable<Message> messages = _context.Messages.OrderByDescending(message => message.SentTime).Take(10);
            //IEnumerable<Message> messages = _context.Messages.OrderByDescending(message => message.SentTime);

            return View(messages);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Mektub(int? Id)
        {
            ViewBag.Messages = "Messages";

            if(Id == null)
            {
                return NotFound();
            }

            Message message = _context.Messages.FirstOrDefault(m => m.Id == Id);

            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }
    }
}