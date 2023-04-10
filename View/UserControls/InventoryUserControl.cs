using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Classes.Controller;
using PadangCyberApp.Model;

namespace PadangCyberApp.View.UserControls
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
        }

        private async void PostCategoryButton_Click(object sender, EventArgs e)
        {
            string json = await WebServiceController.Get("http://127.0.0.1:8000/api/get/category/1000");
            TesModel tesModel = await JsonController.JsonConvertDeserializeAsync<TesModel>(json);
            label1.Text = tesModel.name;
        }
    }
}
