﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Customer", ActionName = "Index" });
        }

        public ActionResult List()
        {
            return View("Result", new Result { ControllerName = "Customer", ActionName = "List" });
        }
    }
}