using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Infrastructure;

namespace ControllerExtensibility.Controllers
{
    /// <summary>
    /// 动作调用控制器，演示动作调用器的使用
    /// </summary>
    public class ActionInvokerController : Controller
    {
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}