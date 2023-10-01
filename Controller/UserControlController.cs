using PadangCyberApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.Controller
{
    class UserControlController
    {

        public static void ChangeUserControlFromPanel<T>(Panel panel) where T : UserControl, new()
        {
            T userControl = new T();
            userControl.Dock = DockStyle.Fill;
            if (panel.Controls.Count != 0)
            {
                if (panel.Controls[0] is IUserControl userControlInterface)
                {
                    userControlInterface.cancelationEvent();
                }
            }
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }
    }
}
