using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Dem1Controller : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{ProductId=1,Name="Samsung",Price=3000M},
            new Product{ProductId=2,Name="Sony",Price=25000M}
        };

        public JsonResult ProductsData()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}