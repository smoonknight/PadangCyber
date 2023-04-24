using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.Classes.Animate
{
    class FormAnimate
    {
        public static async Task fadeIn(Form form)
        {
            form.Opacity = 0;
            float smooth = 0.0f;
            while(form.Opacity < 1)
            {
                await Task.Delay(10);
                smooth += 0.005f;
                form.Opacity += smooth + 0.005;
            }
        }

        public static async Task fadeOut(Form form)
        {
            form.Opacity = 1;
            float smooth = 0.0f;
            while (form.Opacity > 0)
            {
                await Task.Delay(10);
                smooth += 0.005f;
                form.Opacity -= smooth + 0.005;
            }
        }
    }
}
