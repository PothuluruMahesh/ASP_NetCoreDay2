using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResultsExample.Controllers
{
    public class DemoController : Controller
    {
        public FileResult Mahesh()
        {
            return File("~/Content/mahesh.pdf", "application/pdf");
        }
       
    }
}