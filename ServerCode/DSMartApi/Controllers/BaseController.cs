using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DSMartApi.Controllers
{
    public class BaseController : ControllerBase
    {
       
        public object GetUserLogin()
        {
            var a = Request.Headers.Keys;
            return "";
        }
       
    }
}