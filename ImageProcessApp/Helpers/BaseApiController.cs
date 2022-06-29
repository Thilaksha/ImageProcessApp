using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ImageProcess.App.Helpers
{
   
    
    public abstract class BaseApiController : ControllerBase
    {
        public virtual RestResponse ResponseModel(HttpStatusCode status,
            bool isSuccess, string message, object data)
        {
            return new RestResponse(status, isSuccess, message, data);
        }

    }
}
