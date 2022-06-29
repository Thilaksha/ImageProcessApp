using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public sealed  class ImageManuplator
    {
       private ImageManuplator()
        {

        }

        public static bool ResizeImage(int size , byte [] image)
        {
            try
            {
                return true;
            }
            catch
            {
                throw;
            }

        }

        public static bool BlurImage(int size, byte[] image)
        {
            try
            {
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool GrayImage(int size, byte[] image)
        {
            try
            {
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
