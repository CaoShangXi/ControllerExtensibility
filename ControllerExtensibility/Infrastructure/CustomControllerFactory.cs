using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using ControllerExtensibility.Controllers;

namespace ControllerExtensibility.Infrastructure
{
    /// <summary>
    /// 控制器工厂类
    /// </summary>
    public class CustomControllerFactory : IControllerFactory
    {
        /// <summary>
        /// 创建能够对当前请求进行处理的控制器实例
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;
            switch (controllerName)
            {
                case "Product":
                    targetType = typeof(ProductController);
                    break;
                case "Customer":
                    targetType = typeof(CustomerController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Product";
                    targetType = typeof(ProductController);
                    break;
            }
            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable=controller as IDisposable;
            if (disposable!=null)
            {
                disposable.Dispose();
            }
        }
    }
}