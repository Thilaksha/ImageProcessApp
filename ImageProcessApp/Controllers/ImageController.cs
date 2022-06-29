using Image.Model.DTO;
using ImageProcess.App;
using ImageProcess.App.Helpers;
using ImageProcess.App.ImageProcessHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ImageProcessApp.Controllers
{
    [Route("api/ImageService")]
    [ApiController]
    public class ImageController : BaseApiController
    {

        private readonly ILogger logger;
        private readonly IImageProcess imageProcess;
        public ImageController( ILogger<ImageController> logger, IImageProcess imageProcess)
        {
            this.logger = logger;
            this.imageProcess = imageProcess;
        }

       

        [HttpPost("proccess")]
        public RestResponse ImageProcess([FromBody] ImageModelDto param)
        {
            try
            {
                bool retrunValue = imageProcess.ImageProcess(param);
                if(retrunValue)
                    return  ResponseModel(HttpStatusCode.OK, true, RestResponse.Message.Success.ToString(), null);
                else
                    return ResponseModel(HttpStatusCode.BadRequest, true, RestResponse.Message.Error.ToString(), null);
            }
            catch(Exception ex)
            {
                logger.LogInformation(ex, ex.Message);
                return ResponseModel(HttpStatusCode.Conflict, false, RestResponse.Message.Error.ToString(), null);
            }
        }
       
    }
}
