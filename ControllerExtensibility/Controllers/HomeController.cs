using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Models;
using ControllerExtensibility.Infrastructure;

namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "Index" });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "LocalIndex" });
        }
    }
}