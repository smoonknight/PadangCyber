using PadangCyberApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Strings
{
    public class ImageDictionary
    {
        public static Dictionary<string, Bitmap> dine = new Dictionary<string, Bitmap>()
        {
            {"Dine in", Resources.dine_in},
            {"Take away", Resources.take_away}
        };
    }
}
