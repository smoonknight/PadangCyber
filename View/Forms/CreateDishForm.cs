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
        readonly string _categoryId;

        string uniqueId;

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
                string codeProduct = uniqueId + value;
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
                dishPanel1.dishButton.Image = value;
                _imageDish = value;
            }
        }

        public CreateDishForm(string categoryId = "")
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private async void CreateDishForm_Load(object sender, EventArgs e)
        {
            if (_categoryId != null)
            {
                string json = await WebServiceController.Get($"{URLWebService.Get.category}/{_categoryId}");
                CategoryModel categoryModel = await JsonController.JsonConvertDeserializeAsync<CategoryModel>(json);

                categoryComboBox.Items.Add(new ComboBoxItem(categoryModel.categoryId, categoryModel.uniqueId,$"{categoryModel.name} - {categoryModel.uniqueId}"));
                categoryComboBox.SelectedIndex = 0;
                ComboBoxItem comboBoxItem = categoryComboBox.SelectedItem as ComboBoxItem;
                uniqueId = comboBoxItem.uniqueId;
            }
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
            if (!(sender is ComboBoxItem comboBoxItem))
            {
                return;
            }
            uniqueId = comboBoxItem.uniqueId;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 100;
            Dictionary<string, string> post = PostDictionary.Dish(NameDish, "0",_categoryId, CodeDish, "");
            string json = await WebServiceController.Post(URLWebService.Post.dish, post);
            ResponseModel responseModel = await JsonController.JsonConvertDeserializeAsync<ResponseModel>(json);
            
            if (responseModel.status != "Success")
            {
                progressBar.Value = 0;
                return;
            }

            Close();
        }
    }
}
