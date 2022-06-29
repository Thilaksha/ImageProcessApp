using Image.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Image.Model.DTO
{
    public class ImageModelDto
    {
        public byte[] ImageDetal { get; set; }
        public int ImageResizeValue { get; set; }
        public int BlurValue { get; set; }
        public int GrayValue { get; set; }
        public ImageProcessType OptionType  {get;set;}

    }
}
