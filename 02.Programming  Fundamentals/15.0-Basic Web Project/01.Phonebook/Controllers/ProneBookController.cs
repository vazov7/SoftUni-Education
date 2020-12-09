using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01.Phonebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01.Phonebook.Controllers
{
    public class ProneBookController : Controller
    {
        public IActionResult Index()
        {
            return View(DataContext.Contacts);
        }

        [HttpPost]
        public IActionResult Add(Contact model)
        {
            if (ModelState.IsValid)
            {
                DataContext.Contacts.Add(model);
            }
            else
            {
                TempData["Error"] = "Невалидни данни";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
