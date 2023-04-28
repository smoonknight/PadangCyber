using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Classes.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using PadangCyberApp.View.Forms;
using PadangCyberApp.View.Template.CustomPanel;

namespace PadangCyberApp.View.UserControls
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
        }

        async void AddCategoryToCategoryFlowLayoutPanel()
        {
            string json = await WebServiceController.Get(URLWebService.Get.category);
            CategoryModel[] childrensOfCategory = await JsonController.JsonConvertDeserializeAsync<CategoryModel[]>(json);
            categoryFlowLayoutPanel.Controls.Clear();
            foreach (var value in childrensOfCategory)
            {
                CategoryButton categoryButton = new CategoryButton(value.uniqueId, value.name, value.categoryId);
                categoryButton.Click += new EventHandler(CategoryButton_Click);
                categoryFlowLayoutPanel.Controls.Add(categoryButton);
            }
        }

        async void AddDishToDishFlowLayoutPanel()
        {
            string json = await WebServiceController.Get(URLWebService.Get.dish);
            DishModel[] childrensOfDish = await JsonController.JsonConvertDeserializeAsync<DishModel[]>(json);
            dishFlowLayoutPanel.Controls.Clear();
            foreach (var value in childrensOfDish)
            {
                DishPanel dishPanel = new DishPanel();
                dishPanel.dishButton.BackgroundImage = Image.FromStream(await WebServiceController.StreamImage("http://127.0.0.1:8000" + value.photoURL));
                dishPanel.nameDishCommonLabel.Text = value.name;
                dishPanel.codeDishCommonLabel.Text = value.categoryId + value.uniqueId;
                dishPanel.Click += new EventHandler(CategoryButton_Click);
                dishFlowLayoutPanel.Controls.Add(dishPanel);
            }
        }

        async void SyncDish(int prevDishCount = 0)
        {
            await Task.Delay(3000);
            string json = await WebServiceController.Get($"{URLWebService.Get.dish}/count");
            if (JsonController.isJsonNull(json))
            {
                SyncDish(prevDishCount);
                return;
            }

            int dishCount = await JsonController.JsonConvertDeserializeAsync<int>(json);
            label2.Text = dishCount.ToString();

            if (dishCount == prevDishCount)
            {
                SyncDish(prevDishCount);
                return;
            }

            AddDishToDishFlowLayoutPanel();
            SyncDish(dishCount);
        }
        async void SyncCategory(int prevCategoryCount = 0)
        {
            await Task.Delay(3000);
            string json = await WebServiceController.Get($"{URLWebService.Get.category}/count");
            if (JsonController.isJsonNull(json))
            {
                SyncCategory(prevCategoryCount);
                return;
            }

            int categoryCount = await JsonController.JsonConvertDeserializeAsync<int>(json);
            label1.Text = categoryCount.ToString();

            if (categoryCount == prevCategoryCount)
            {
                SyncCategory(prevCategoryCount);
                return;
            }
            AddCategoryToCategoryFlowLayoutPanel();
            SyncCategory(categoryCount);
        }
        void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryButton categoryButton = sender as CategoryButton;
            CategoryDescriptionForm categoryDescriptionForm = new CategoryDescriptionForm(categoryButton._idTable);
            categoryDescriptionForm.ShowDialog();

        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            SyncCategory();
            SyncDish();
        }

        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = new CreateCategoryForm();
            createCategoryForm.ShowDialog();
        }

        private void createDishButton_Click(object sender, EventArgs e)
        {
            new CreateDishForm().ShowDialog();
        }
    }
}
