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
            new Product{ProductId=1,Name="Sony",Price=3000M},
            new Product{ProductId=2,Name="Samsung",Price=2000M}
        };
        public JsonResult ProductsData()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}