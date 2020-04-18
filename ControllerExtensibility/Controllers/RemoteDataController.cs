using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Models;
using System.Threading.Tasks;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : Controller
    {

        //public ActionResult Data()
        //{
        //    RemoteService service=new RemoteService();
        //    string data=service.GetRemoteData();
        //    return View((object)data);
        //}

        public async Task<ActionResult> Data()
        {
            RemoteService service = new RemoteService();
            string data=await Task<string>.Factory.StartNew(()=>  new RemoteService().GetRemoteData());
            return View((object)data);
        }

        /// <summary>
        /// 异步控制器方法
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> ConsumeAsyncMethod()
        {
            string data = await new RemoteService().GetRemoteDataAsync();
            return View("Data",(object)data);
        }
    }
}