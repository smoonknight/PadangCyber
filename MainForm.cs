using PadangCyberApp.View.UserControls;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.BringToFront();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            orderUserControl1.BringToFront();
        }
    }
}
