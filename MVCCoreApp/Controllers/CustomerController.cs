using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("khach-hang/vip")] //Attribute Routing
        public string Vip()
        {
            return "Khach hang Vip";
        }

        [Route("khach-hang")]
        [Route("khach-hang/normal")] //Attribute Routing
        public string Normal()
        {
            return "Khach hang thuong";
        }
    }
}