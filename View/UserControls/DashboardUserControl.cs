using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadangCyberApp.View.Template.CustomButton;
using System.Windows.Forms;

namespace PadangCyberApp.View.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                TableLayoutPanel flowLayoutPanel = new OrderBox().Create("krsss", "Dine in", "Rp. 10000", "Satria", "12", "11:00", "12");
                ListOrderFlowLayoutPanel.Controls.Add(flowLayoutPanel);
            }
         }
    }
}
