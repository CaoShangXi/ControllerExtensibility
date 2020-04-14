using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Infrastructure
{
    /// <summary>
    /// 创建自定义动作调用器，如果控制器是通过Controller类派生而来的，那么将由动作调用器调用动作；如果是直接通过IController接口创建控制器，
    /// 则你要自己去负责执行动作。
    /// </summary>
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName=="Index")
            {
                controllerContext.HttpContext.Response.Write("This is output from the Index action");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}