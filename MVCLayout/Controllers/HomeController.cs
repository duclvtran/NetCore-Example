using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLayout.Models.Home;

namespace MVCLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Welcome"] = "Hello world";
            ViewData["Message"] = "Message from Index";
            ViewData["Product"] = new IndexModel() { Id = 1, Name = "Vu", Age = "Age" };

            ViewBag.Welcome1 = "Welcome1";
            ViewBag.Message1 = "Message1";
            ViewBag.Product1 = new IndexModel() { Id = 1, Name = "Name", Age = "Age" };

            return View();
        }
    }
}