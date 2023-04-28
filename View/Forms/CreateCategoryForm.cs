using PadangCyberApp.Classes.Controller;
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
                return;
            }
            if (UniqueIdTextbox.Text == "")
            {
                return;
            }

            ProgressBar.Value = 100;
            var values = PostDictionary.Category(NameTextBox.Text, UniqueIdTextbox.Text);
            string json = await WebServiceController.Post(URLWebService.Post.category, values);
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);
            if (responseModel.status != "Success")
            {
                ProgressBar.Value = 0;
                new AlertForm(false, "Gagal menyimpan", "Periksa kembali koneksi kamu").Show();
                return;
            }
            new AlertForm(true, "Tersimpan", "Kategori telah disimpan").Show();
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
