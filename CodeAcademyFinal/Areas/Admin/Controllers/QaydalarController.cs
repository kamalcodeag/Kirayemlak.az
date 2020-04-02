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
    public class QaydalarController : Controller
    {
        private readonly RentEstateDb _context;
        public QaydalarController(RentEstateDb context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewBag.Rules = "Rules";

            Rule rule = _context.Rules.FirstOrDefault();

            return View(rule);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int? Id, Rule rule)
        {
            ViewBag.Rules = "Rules";

            if(Id != null)
            {
                Rule ruleToBeUpdated = _context.Rules.FirstOrDefault(r => r.Id == Id);

                if (ruleToBeUpdated != null)
                {
                    ruleToBeUpdated.RuleText = rule.RuleText.Trim();
                    await _context.SaveChangesAsync();
                }
            }

            TempData["RuleUpdated"] = true;

            return RedirectToAction("Index", "Qaydalar");
        }
    }
}