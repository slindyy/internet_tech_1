using Internet_Tech_1.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Tech_1.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationContext db;

        public ProductsController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Products()
        {
            return View(db.Product.ToList());
        }
    }
}
