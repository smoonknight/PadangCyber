using System;
using System.Windows.Forms;
using PadangCyberApp.View.Template.CustomTableLayoutPanel;

namespace PadangCyberApp.View.Forms
{
    public partial class OrderForm : Form
    {
        private readonly string orderId;
        public OrderForm(string ID = "")
        {
            InitializeComponent();
            orderId = ID;
        }

        private void HumbergerButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ListOrderPanel.Controls.Add(new OrderDataTableLayoutPanel("2", "2000", "bakar", "4000"));
        }
    }
}
