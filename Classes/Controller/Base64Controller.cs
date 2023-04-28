using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Controller
{
    class Base64Controller
    {
        public static string ConvertImageToBase64(string directory)
        {
            byte[] imageArray = File.ReadAllBytes(directory);
            return Convert.ToBase64String(imageArray);
        }

        public static string ConvertImageToBase64(Image image)
        {
            var memoryStream = new MemoryStream();
            image.Save(memoryStream, image.RawFormat);
            byte[] imageArray = memoryStream.ToArray();
            return Convert.ToBase64String(imageArray);
        }

        public static Image ConvertBase64ToImage(string base64)
        {
            return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
        }
    }
}
