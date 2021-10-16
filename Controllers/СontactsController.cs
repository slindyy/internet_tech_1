using Internet_Tech_1.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Tech_1.Controllers
{
    public class СontactsController : Controller
    {
        private ApplicationContext db;

        public СontactsController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Сontacts()
        {
            return View();
        }
    }
}
