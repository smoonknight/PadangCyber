using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Sync;

namespace PadangCyberApp.View.Forms
{
    public partial class CategoryDescriptionForm : Form
    {
        public readonly string _id;
        public CategoryDescriptionForm(string id = "")
        {
            InitializeComponent();
            _id = id;
        }

        private async void CategoryDescriptionForm_Load(object sender, EventArgs e)
        {
            nameValueLabel.Text = "Tunggu sebentar ya...";
            codeValueLabel.Text = "Tunggu sebentar ya...";
            totalDishValueLabel.Text = "Tunggu sebentar ya...";
            try
            {
                string json = await WebServiceController.Get($"{URLWebService.Get.category}/{_id}");

                CategoryModel categoryModel = await JsonController.JsonConvertDeserializeAsync<CategoryModel>(json);
                nameValueLabel.Text = categoryModel.name;
                codeValueLabel.Text = categoryModel.codeCategory;
                totalDishValueLabel.Text = categoryModel.totalDish;
            }
            catch
            {
                FormController.mainForm.NotificationLoader("Gagal memuat");
                Close();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            string json = await WebServiceController.Delete($"{URLWebService.Delete.category}/{_id}");
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);

            if (responseModel.status != "OK")
            {
                new AlertForm(false, responseModel.status, responseModel.message).Show();
                return;
            }
            Synchronizer synchronizer = new Synchronizer();
            await synchronizer.ForceUpdateCategory();
            new AlertForm(true, responseModel.status, responseModel.message).Show();
            Close();
        }

        private void createDishButton_Click(object sender, EventArgs e)
        {
            CreateDishForm createDishForm = new CreateDishForm(_id);
            createDishForm.ShowDialog();
        }
    }
}
