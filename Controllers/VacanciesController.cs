using Internet_Tech_1.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Tech_1.Controllers
{
    public class VacanciesController : Controller
    {
        private ApplicationContext db;

        public VacanciesController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Vacancies()
        {
            return View(db.Vacancies.ToList());
        }
    }
}
