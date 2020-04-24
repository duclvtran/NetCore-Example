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
            var list = new List<ProductModel>();
            list.Add(new ProductModel() { Id = 1, Name = "Nguyen Van A", Age = 22 });
            list.Add(new ProductModel() { Id = 2, Name = "Nguyen Van B", Age = 24 });
            return View(list);
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