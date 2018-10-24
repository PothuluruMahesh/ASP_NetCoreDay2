using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSONExample.Models;

namespace JSONExample.Controllers
{
    public class DemoController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{ProductId=1,Name="Samsung",Price=20000M},
            new Product{ProductId=2,Name="Nike Shoo",Price=4000M}
        };

        public JsonResult ProductsData()
        {
            return Json(products,JsonRequestBehavior.AllowGet);
        }
    }
}