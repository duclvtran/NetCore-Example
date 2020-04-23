using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "Hello from Index Model";
            return View(model);
        }

        public string Test()
        {
            return "Hello from Index";
            //return View();
        }
    }
}