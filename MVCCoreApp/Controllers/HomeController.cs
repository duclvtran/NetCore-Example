using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly HttpContext _context;

        //public HomeController(HttpContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Index Model, ID=" + id;
            return View(model);
        }

        public IActionResult Index1()
        {
            return View();
        }

        //public string Test()
        //{
        //    return "Hello from Index";
        //    //return View();
        //}

        //public async void Index()
        //{
        //    _context.Response.StatusCode = 200;
        //    _context.Response.ContentType = "text/html";
        //    _context.Response.Headers.Add("HeaderName", "HeaderValue");
        //    byte[] content = Encoding.ASCII.GetBytes($"<html><body>Hello World</body></html>");
        //    await _context.Response.Body.WriteAsync(content, 0, content.Length);
        //}

        //public IActionResult Index()
        //{
        //    return Content("Hello world");
        //}

        //public IActionResult Index(int Id)
        //{
        //    if (Id == 0)
        //    {
        //        return NotFound();
        //    }
        //    else
        //        return Content("Hello world");
        //}

        //public IActionResult Index()
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello world from View Result";
        //    return View(model);
        //}

        //public IActionResult Index()
        //{
        //    Thread.Sleep(5000);
        //    return Redirect("/khach-hang/vip");
        //}
    }
}