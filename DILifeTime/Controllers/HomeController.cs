using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DILifeTime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DILifeTime.Controllers
{
    public class HomeController : Controller
    {
        private ITransientSerivce _transientSerivce1;
        private ITransientSerivce _transientSerivce2;
        private IScopedService _scopedService1;
        private IScopedService _scopedService2;
        private ISingletonServie _singletonServie1;
        private ISingletonServie _singletonServie2;

        public HomeController(ITransientSerivce transientSerivce1
            , ITransientSerivce transientSerivce2
            , IScopedService scopedService1
            , IScopedService scopedService2
            , ISingletonServie singletonServie1
            , ISingletonServie singletonServie2)
        {
            _transientSerivce1 = transientSerivce1;
            _transientSerivce2 = transientSerivce2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonServie1 = singletonServie1;
            _singletonServie2 = singletonServie2;
        }

        public IActionResult Index()
        {
            ViewBag.message1 = _transientSerivce1.GetID().ToString();
            ViewBag.message2 = _transientSerivce2.GetID().ToString();
            ViewBag.message3 = _scopedService1.GetID().ToString();
            ViewBag.message4 = _scopedService2.GetID().ToString();
            ViewBag.message5 = _singletonServie1.GetID().ToString();
            ViewBag.message6 = _singletonServie2.GetID().ToString();
            return View();
        }
    }
}