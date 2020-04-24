using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreForm.Models;

namespace MVCCoreForm.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new UserModel() { UserName = "", Password = "", Email = "linh@linh", CreateDate = DateTime.Now };
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Username = " + model.UserName + ", Password = " + model.Password + ", Email = " + model.Email;
            }
            else
            {
                return View(model);
            }
            return Content(message);
        }
    }
}