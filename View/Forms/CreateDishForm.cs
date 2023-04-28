using PadangCyberApp.Classes.Controller;
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
        string _categoryUniqueId;

        string _categoryId;

        string CategoryUniqueId
        {
            get
            {
                return _categoryUniqueId;
            }
            set
            {
                string codeProduct = value + _codeDish;
                dishPanel1.codeDishCommonLabel.Text = codeProduct;
                _categoryUniqueId = value;
            }
        }

        string _nameDish;

        string NameDish
        {
            get
            {
                return _nameDish;
            }
            set
            {
                dishPanel1.nameDishCommonLabel.Text = value;
                _nameDish = value;
            }
        }

        string _codeDish;
        string CodeDish
        {
            get
            {
                return _codeDish;
            }
            set
            {
                string codeProduct = _categoryUniqueId + value;
                dishPanel1.codeDishCommonLabel.Text = codeProduct;
                _codeDish = value;
            }
        }

        Image _imageDish;
        Image ImageDish
        {
            get
            {
                return _imageDish;
            }
            set
            {
                dishPanel1.dishButton.BackgroundImage = value;
                _imageDish = value;
            }
        }

        public CreateDishForm(string categoryId = null)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private async void CreateDishForm_Load(object sender, EventArgs e)
        {
            string json;
            ComboBoxItem comboBoxItem;
            if (_categoryId != null)
            {
                json = await WebServiceController.Get($"{URLWebService.Get.category}/{_categoryId}");
                CategoryModel categoryModel = await JsonController.JsonConvertDeserializeAsync<CategoryModel>(json);

                categoryComboBox.Items.Add(new ComboBoxItem(categoryModel.categoryId, categoryModel.uniqueId,$"{categoryModel.name} - {categoryModel.uniqueId}"));
                categoryComboBox.SelectedIndex = 0;
                comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
                _categoryId = comboBoxItem.value;
                return;
            }
            json = await WebServiceController.Get(URLWebService.Get.category);
            CategoryModel[] childrensOfCategory = await JsonController.JsonConvertDeserializeAsync<CategoryModel[]>(json);

            foreach (var categoryModel in childrensOfCategory)
            {
                categoryComboBox.Items.Add(new ComboBoxItem(categoryModel.categoryId, categoryModel.uniqueId, $"{categoryModel.name} - {categoryModel.uniqueId}"));
            }
            categoryComboBox.SelectedIndex = 0;
            comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
            ImageDish = dishPanel1.dishButton.BackgroundImage;
            _categoryId = comboBoxItem.value;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            NameDish = textBox.Text;
        }

        private void UniqueIdTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            CodeDish = textBox.Text;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
            CategoryUniqueId = comboBoxItem.uniqueId;
            _categoryId = comboBoxItem.value;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 100;
            string base64Image = Base64Controller.ConvertImageToBase64(ImageDish);
            Dictionary<string, string> post = PostDictionary.Dish(NameDish, "0", _categoryId, CodeDish, base64Image);
            string json = await WebServiceController.Post(URLWebService.Post.dish, post);
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);
            
            if (responseModel.status != "Success")
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
            var openFile = openFileDialog.ShowDialog();
            if (openFile != DialogResult.OK)
            {
                return;
            }
            ImageDish = Image.FromStream(openFileDialog.OpenFile());
        }
    }
}
