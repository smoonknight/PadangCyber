using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace PadangCyberApp.Controller
{
    class ControlController
    {
        public static void InheritanceAllControlForClickEvents(ControlCollection controlCollection, EventHandler delegateEvent)
        {
            foreach (Control control in controlCollection)
            {
                control.Click += delegateEvent;
                if (control.HasChildren)
                {
                    InheritanceAllControlForClickEvents(control.Controls, delegateEvent);
                }
            }
        }

        public static void InheritanceAllControlForMouseHoverEvents(ControlCollection controlCollection, EventHandler delegateEvent)
        {
            foreach (Control control in controlCollection)
            {
                control.MouseHover += delegateEvent;
                if (control.HasChildren)
                {
                    InheritanceAllControlForMouseHoverEvents(control.Controls, delegateEvent);
                }
            }
        }
    }
}
