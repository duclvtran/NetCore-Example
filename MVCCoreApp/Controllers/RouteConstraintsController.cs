using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class RouteConstraintsController : Controller
    {
        public string PostById(int id)
        {
            return "Post By Id = " + id;
        }

        public string PostByName(string id)
        {
            return "Post By Name = " + id;
        }

        public string GetYear(int year)
        {
            return "Get Year = " + year;
        }
    }
}