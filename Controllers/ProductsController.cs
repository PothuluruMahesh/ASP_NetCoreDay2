using DataBaseExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBaseExample.Controllers
{
    public class ProductsController : Controller
    {
        ProductsContext db = new ProductsContext();
        public ViewResult Index()
        {
            return View(db.ProductsTable.ToList());
        }
    }
}