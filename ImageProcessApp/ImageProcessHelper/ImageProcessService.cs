using Image.Model.DTO;
using Image.Model.Enum;
using ImageProcess.App.ImageProcessHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcessApp.ImageProcessHelper
{
    public class ImageProcessService : IImageProcess
    {
       

        public bool ImageProcess(ImageModelDto param)
        {
            try
            {
                IImageProcessServicecs processOptions =  StrategyLocator.GetService< IImageProcessServicecs>(param.OptionType);
                return   processOptions.ConvertImage(param);
            }
            catch
            {
                throw;
            }
        }
    }
}
