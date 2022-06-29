using Image.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public class OptionResize : IImageProcessServicecs
    {
        public bool ConvertImage(ImageModelDto param)
        {
            try
            {
                bool isResize = ImageManuplator.ResizeImage(param.ImageResizeValue, param.ImageDetal);              
                if (isResize )
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
