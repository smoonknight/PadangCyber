using System;
using System.Drawing;
using System.Windows.Forms;
using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using PadangCyberApp.View.Template.CustomPanel;
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
            AddCategoryToCategoryFlowLayoutPanel();
            AddDishToDishFlowLayoutPanel();
            //GetCustomerIdValue();
        }

        async void GetCustomerIdValue()
        {
            string json = await WebServiceController.Get($"{URLWebService.Get.customer}/{orderId}");
            CustomerModel customerModel = await JsonController.JsonConvertDeserializeAsync<CustomerModel>(json);

            nameCustomerTextBox.Text = customerModel.nameCustomer;
            numberTableLabel.Text = customerModel.numberTable;
            numberQueueLabel.Text = customerModel.numberQueue;
/*            foreach (OrderList orderList in customerModel.orderList)
            {
                OrderDataTableLayoutPanel orderDataTableLayoutPanel = new OrderDataTableLayoutPanel(orderList.amount, orderList.unitPrice, orderList.unitName, orderList.totalPrice);
                ListOrderPanel.Controls.Add(orderDataTableLayoutPanel);
            }*/
        }

        void AddCategoryToCategoryFlowLayoutPanel()
        {
            foreach (var value in ModelController.DataCategoryModel)
            {
                CategoryButton categoryButton = new CategoryButton(value.uid, value.name, value.codeCategory);
                CategoryFoodFlowLayoutPanel.Controls.Add(categoryButton);
            }
        }

        async void AddDishToDishFlowLayoutPanel()
        {
            foreach (var value in ModelController.DataDishModel)
            {
                DishPanel dishPanel = new DishPanel();
                try
                {
                    dishPanel.dishButton.BackgroundImage = Image.FromStream(await WebServiceController.StreamImage("http://127.0.0.1:8000" + value.photoURL));
                }
                catch
                {
                    
                }
                dishPanel.nameDishCommonLabel.Text = value.name;
                dishPanel.codeDishCommonLabel.Text = value.categoryUid + value.uid;
                //dishPanel.Click += new EventHandler();
                dishFlowLayoutPanel.Controls.Add(dishPanel);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Cari nama hidangan ...")
            {
                SearchTextBox.ForeColor = Color.Gray;
                return;
            }
            SearchTextBox.ForeColor = Color.Black;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                if (SearchTextBox.Text == "Cari nama hidangan ...")
                {
                    SearchTextBox.Text = "Cari nama hidangan ...";
                    SearchTextBox.ForeColor = Color.Gray;
                    return;
                }
                SearchTextBox.ForeColor = Color.Black;
            }
        }
    }
}
