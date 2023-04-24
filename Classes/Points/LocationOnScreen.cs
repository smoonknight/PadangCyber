using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.Classes.Points
{
    class LocationOnScreen
    {
        public static Point BottomRight(Control control)
        {
            Rectangle workingArea = Screen.GetWorkingArea(control);
            return new Point(workingArea.Right - control.Width, workingArea.Bottom - control.Height);
        }
    }
}
