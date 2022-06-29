using Image.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public interface IImageProcessServicecs
    {
        bool ConvertImage(ImageModelDto param);
    }
}
