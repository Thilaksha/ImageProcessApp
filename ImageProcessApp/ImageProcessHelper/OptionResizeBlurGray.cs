using Image.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public class OptionResizeBlurGray : IImageProcessServicecs
    {
        public bool ConvertImage(ImageModelDto param)
        {
            try
            {
                bool isResize = ImageManuplator.ResizeImage(param.ImageResizeValue, param.ImageDetal);
                bool isBlure = ImageManuplator.BlurImage(param.BlurValue, param.ImageDetal);
                bool isGray = ImageManuplator.GrayImage(param.GrayValue, param.ImageDetal);
                if (isResize && isBlure && isGray)
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
