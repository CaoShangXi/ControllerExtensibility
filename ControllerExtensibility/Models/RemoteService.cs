using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace ControllerExtensibility.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(2000);
            return "Hello from the other side of the world";
        }

        /// <summary>
        /// 异步方法
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetRemoteDataAsync()
        {
            return await Task<string>.Factory.StartNew(()=> { Thread.Sleep(2000);return "Hello from the other side of the world"; });
        }
    }
}