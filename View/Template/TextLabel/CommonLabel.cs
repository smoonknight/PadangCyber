using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PadangCyberApp.View.Template.TextLabel
{
    public class CommonLabel
    {
        public static Label Create(string text, int emSize, FontStyle fontStyle = FontStyle.Regular)
        {
            Label commonLabel = new Label();
            commonLabel.Text = text;
            commonLabel.AutoSize = false;
            commonLabel.Font = new Font("Century Schoolbook", emSize, fontStyle);
            
            return commonLabel;
        }
    }
}
