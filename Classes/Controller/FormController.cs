using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.Classes.Controller
{
    internal class FormController
    {
        public static void CloseProgram()
        {
            Application.Exit();
        }

        public static void CloseForm(Form form)
        {
            form.Close();
        }

        public static FormWindowState MinimizeProgram(FormWindowState windowState)
        {
            return FormWindowState.Minimized;
        }
        public static FormWindowState MaximizeProgram(FormWindowState windowState)
        {
            return FormWindowState.Maximized;
        }
    }
}
