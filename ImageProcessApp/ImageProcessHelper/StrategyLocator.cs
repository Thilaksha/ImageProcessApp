using Image.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProcess.App.ImageProcessHelper
{
    public sealed class StrategyLocator
    {
        private static Dictionary<object, object> strategycontainer = null;
        private StrategyLocator()
        {

        }
        
        public static T GetService<T>(ImageProcessType option)
        {          
            if (strategycontainer == null)
            {
                strategycontainer = new Dictionary<object, object>();
                strategycontainer.Add(ImageProcessType.OptionResizeBlur, new OptionResizeBlur());
                strategycontainer.Add(ImageProcessType.OptionResize, new OptionResize());
                strategycontainer.Add(ImageProcessType.OptionResizeBlurGray, new OptionResizeBlurGray());                

            }
         
            try
            {
                return (T)strategycontainer[option];
            }
            catch (Exception)
            {
                throw new NotImplementedException("Strategy not available.");
            }
        }
    }
}
