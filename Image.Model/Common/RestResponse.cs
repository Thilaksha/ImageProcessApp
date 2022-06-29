using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Image.Model.Common
{
    public class RestResponse
    {

        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccsess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
