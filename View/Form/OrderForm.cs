using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Model;
using PadangCyberApp.View.Template.CustomTableLayoutPanel;

namespace PadangCyberApp
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            TableLayoutPanel tableLayoutPanel = OrderTableLayoutPanel.Create("2", "20000", "Ayam Bakar", "40000");
            ListOrderPanel.Controls.Add(tableLayoutPanel);
        }

        private void HumbergerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
