using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Classes.Objects;
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
    public partial class CreateDishForm : Form
    {
        string _categoryUid;

        public CreateDishForm(string categoryId = null)
        {
            InitializeComponent();
            _categoryUid = categoryId;
        }

        private async void CreateDishForm_Load(object sender, EventArgs e)
        {
            string json;
            ComboBoxItem comboBoxItem;
            if (_categoryUid != null)
            {
                json = await WebServiceController.Get($"{URLWebService.Get.category}/{_categoryUid}");
                CategoryModel categoryModel = await JsonController.JsonConvertDeserializeAsync<CategoryModel>(json);

                categoryComboBox.Items.Add(new ComboBoxItem(categoryModel.uid, categoryModel.codeCategory, $"{categoryModel.name} - {categoryModel.codeCategory}"));
                categoryComboBox.SelectedIndex = 0;
                comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
                _categoryUid = comboBoxItem.uid;
                return;
            }
            json = await WebServiceController.Get(URLWebService.Get.category);
            CategoryModel[] childrensOfCategory = await JsonController.JsonConvertDeserializeAsync<CategoryModel[]>(json);

            foreach (var categoryModel in childrensOfCategory)
            {
                categoryComboBox.Items.Add(new ComboBoxItem(categoryModel.uid, categoryModel.codeCategory, $"{categoryModel.name} - {categoryModel.codeCategory}"));
            }
            categoryComboBox.SelectedIndex = 0;
            comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
            _categoryUid = comboBoxItem.uid;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            dishPanel.nameDish = textBox.Text;
        }

        private void UniqueIdTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            dishPanel.codeDish = textBox.Text;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
            dishPanel.codeCategory = comboBoxItem.codeCategory;
            _categoryUid = comboBoxItem.uid;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 100;
            string categoryId = _categoryUid;
            string codeDish = codeDishTextbox.Text;
            string nameDish = nameTextBox.Text;
            string unitPrice = unitPriceTextBox.Text;

            //byte[] imageData = ImageController.ImageToByteConverter(dishPanel.dishButton.BackgroundImage);

            Dictionary<string, string> post = PostDictionary.Dish(categoryId, codeDish, nameDish, unitPrice);
            string json = await WebServiceController.Post(URLWebService.Post.dish, post);
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);

            if (responseModel.status != "OK")
            {
                new AlertForm(false, "Gagal menyimpan", "Periksa kembali koneksi kamu").Show();
                progressBar.Value = 0;
                return;
            }
            new AlertForm(true, "Tersimpan", "Hidangan telah tercatat").Show();
            Close();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
/*            var openFile = openFileDialog.ShowDialog();
            if (openFile != DialogResult.OK)
            {
                return;
            }

            ImageDish = Image.FromStream(openFileDialog.OpenFile());*/
        }
    }
}
