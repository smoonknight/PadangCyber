using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp
{
    public partial class HeaderUserControl : UserControl
    {
        private bool isMaximized;
        public HeaderUserControl()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            SetParentFormWindowState(FormWindowState.Minimized);
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            isMaximized = !isMaximized;
            if (!isMaximized)
            {
                SetParentFormWindowState(FormWindowState.Maximized);
                return;
            }
            SetParentFormWindowState(FormWindowState.Normal);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form orderForm = Parent as Form;
            if (orderForm == null)
            {
                return;
            }
            orderForm.Close();
        }

        private void SetParentFormWindowState(FormWindowState formWindowState)
        {
            Form orderForm = Parent as Form;
            if (orderForm == null)
            {
                return;
            }
            orderForm.WindowState = formWindowState;
        }
    }
}
