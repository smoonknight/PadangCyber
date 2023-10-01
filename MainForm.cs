using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using PadangCyberApp.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Sync;
using PadangCyberApp.View.Forms;

namespace PadangCyberApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UserControlController.ChangeUserControlFromPanel<DashboardUserControl>(userControlPanel);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            UserControlController.ChangeUserControlFromPanel<InventoryUserControl>(userControlPanel);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            UserControlController.ChangeUserControlFromPanel<OrderUserControl>(userControlPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserControlController.ChangeUserControlFromPanel<InventoryUserControl>(userControlPanel);
            Synchronizer synchronizer = new Synchronizer();
            synchronizer.StartLastUpdatedAsync(statusCommonLabel);
        }

        public void NotificationLoader(string message)
        {
            NotificationForm notificationForm = new NotificationForm(message);
            notificationForm.Show(this);
        }


    }
}
