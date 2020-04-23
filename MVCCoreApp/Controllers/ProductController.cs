using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //domain/product/edit
        //domain/product/modify
        //[ActionName("modify")]
        //[Route("product/modify")]
        //[NonAction]
        [HttpGet]
        public IActionResult Edit(string id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ProductModel productModel)
        {
            return Redirect("Home/Index");
        }

        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return new List<ProductModel>();
        }
    }
}