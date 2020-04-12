using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ControllerExtensibility.Controllers;

namespace ControllerExtensibility.Infrastructure
{
    /// <summary>
    /// 控制激活器
    /// </summary>
    public class CustomControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            if (controllerType==typeof(ProductController))
            {
                controllerType = typeof(CustomerController);
            }
            return (IController)DependencyResolver.Current.GetService(controllerType);//返回控制器实例
        }
    }
}