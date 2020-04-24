using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreForm.Models;

namespace MVCCoreForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new ProductEditModel() { Name = "Dien ten", Rate = 5, Rating = 5 };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new ProductEditModel() { Name = "Dien ten", Rate = 5, Rating = 5 };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }

        [HttpGet]
        public IActionResult NoModelBinding()
        {
            var model = new ProductEditModel() { Name = "Dien ten", Rate = 5, Rating = 5 };
            return View(model);
        }

        [HttpPost]
        public IActionResult NoModelBinding(ProductEditModel model1)
        {
            ProductEditModel model = new ProductEditModel();
            string message = "";

            model.Name = Request.Form["Name"].ToString();
            model.Rate = Convert.ToDecimal(Request.Form["Rate"]);
            model.Rating = Convert.ToInt32(Request.Form["Rateing"]);

            message = "product " + model.Name + " created successfully";
            return Content(message);
        }

        [HttpGet]
        public IActionResult FormAndQuery()
        {
            var model = new ProductEditModel() { Name = "Dien ten", Rate = 5, Rating = 5, Email = "linh@linh", Id = 11 };
            return View(model);
        }

        [HttpPost]
        public IActionResult FormAndQuery([FromQuery] string Name, ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}