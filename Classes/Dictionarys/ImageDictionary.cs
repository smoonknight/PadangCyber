using PadangCyberApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Dictionarys
{
    public class ImageDictionary
    {
        public static Bitmap getImage(string name)
        {
            Dictionary<string, Bitmap> imageDictionary = new Dictionary<string, Bitmap>();
            imageDictionary.Add("Dine in", Resources.dine_in);
            imageDictionary.Add("Take away", Resources.take_away);

            if (imageDictionary[name] == null)
            {
                return null;
            }
            return imageDictionary[name];
        }
    }
}
