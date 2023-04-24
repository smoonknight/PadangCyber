using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PadangCyberApp.View.Template.CustomLabel
{
    public class CommonLabel : Label
    {
        public CommonLabel()
        {
            AutoSize = false;
            Font = new Font("Century Schoolbook", 12, FontStyle.Regular);
        }

        public CommonLabel(int emSize, FontStyle fontStyle = FontStyle.Regular)
        {
            AutoSize = false;
            Font = new Font("Century Schoolbook", emSize, fontStyle);
        }
        public CommonLabel(string text, int emSize = 12, FontStyle fontStyle = FontStyle.Regular)
        {
            Text = text;
            AutoSize = false;
            Font = new Font("Century Schoolbook", emSize, fontStyle);
        }
    }
}
