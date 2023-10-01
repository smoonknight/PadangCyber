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

namespace PadangCyberApp.View.Forms
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                new AlertForm(false, "kesalahan", "nama atau kode kosong, harap diisi").Show();

                return;
            }
            if (UniqueIdTextbox.Text == "")
            {
                new AlertForm(false, "kesalahan", "nama atau kode kosong, harap diisi").Show();

                return;
            }

            ProgressBar.Value = 0;
            var values = PostDictionary.Category(NameTextBox.Text, UniqueIdTextbox.Text);
            ProgressBar.Value = 25;
            string json = await WebServiceController.Post(URLWebService.Post.category, values);
            ProgressBar.Value = 100;
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);
            if (responseModel.status != "OK")
            {
                ProgressBar.Value = 0;
                new AlertForm(false, responseModel.status, responseModel.message).Show();
                return;
            }

            new AlertForm(true, responseModel.status, responseModel.message).Show();

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
