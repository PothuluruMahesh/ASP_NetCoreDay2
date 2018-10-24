using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ViewResult Index()
        {


            ViewBag.name = "mahesh";
            ViewBag.categories = new List<string>()
            {
                 "Samsung",
                "Sony",
                "LG",
                "HP"
            };
            return View();


            /*
            ViewData["name"] = "Mahesh";
            ViewData["Products"] = new List<string>()
            {
                "Samsung",
                "Sony",
                "LG",
                "HP"
            };
           // string name = "Mahesh";
            return View();
            */
        }
    }
}