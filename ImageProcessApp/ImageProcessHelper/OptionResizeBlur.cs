using Image.Model.DTO;
using ImageProcess.App.ImageProcessHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public class OptionResizeBlur : IImageProcessServicecs
    {
        public bool ConvertImage(ImageModelDto param)
        {
            try
            {
               bool isResize=  ImageManuplator.ResizeImage(param.ImageResizeValue , param.ImageDetal);
               bool isBlure =   ImageManuplator.BlurImage(param.BlurValue, param.ImageDetal);
                if (isResize && isBlure)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }
    }
}
