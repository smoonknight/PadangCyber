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
using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using PadangCyberApp.View.Forms;
using PadangCyberApp.View.Template.CustomPanel;
using System.Threading;
using PadangCyberApp.Interface;

namespace PadangCyberApp.View.UserControls
{
    public partial class InventoryUserControl : UserControl, IUserControl
    {
        private DateTime prevDataDishLastUpdated;
        private DateTime prevDataCategoryLastUpdated;

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public InventoryUserControl()
        {
            InitializeComponent();
        }
        async Task AddCategoryToCategoryFlowLayoutPanel()
        {
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            categoryFlowLayoutPanel.SuspendLayout();
            categoryFlowLayoutPanel.Controls.Clear();
            Control[] controls = new Control[ModelController.DataCategoryModel.Length];
            int counter = 0;
            try
            {
                await Task.Run(() =>
                {
                    foreach (var value in ModelController.DataCategoryModel)
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                        }
                        CategoryButton categoryButton = new CategoryButton(value.uid, value.name, value.codeCategory);
                        controls[counter] = categoryButton;
                        counter++;
                    }
                }, cancellationToken);
                categoryFlowLayoutPanel.Controls.AddRange(controls);
                categoryFlowLayoutPanel.ResumeLayout();
            }
            catch (OperationCanceledException)
            {

            }
        }

        async Task AddDishToDishFlowLayoutPanel()
        {
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            dishFlowLayoutPanel.SuspendLayout();
            dishFlowLayoutPanel.Controls.Clear();
            Control[] controls = new Control[ModelController.DataDishModel.Length];
            int counter = 0;
            try
            {
                await Task.Run(async () =>
                {
                    foreach (var value in ModelController.DataDishModel)
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                        }
                        DishPanel dishPanel = new DishPanel();
                        dishPanel.nameDishCommonLabel.Text = value.name;
                        dishPanel.codeDishCommonLabel.Text = value.codeCategory + value.codeDish;
                        controls[counter] = dishPanel;
                        counter++;
                    }
                }, cancellationToken);
                dishFlowLayoutPanel.Controls.AddRange(controls);
                dishFlowLayoutPanel.ResumeLayout();
            }
            catch (OperationCanceledException)
            {

            }
        }

        async void SyncDish()
        {
            while (true)
            {
                if (ModelController.DataDishModel == null)
                {
                    await Task.Delay(1000);
                    continue;
                }
                if (prevDataDishLastUpdated == ModelController.dataDishLastUpdated)
                {
                    await Task.Delay(1000);
                    continue;
                }

                prevDataDishLastUpdated = ModelController.dataDishLastUpdated;
                await AddDishToDishFlowLayoutPanel();
                await Task.Delay(1000);
            }
        }

        async void SyncCategory()
        {
            while (true)
            {
                if (ModelController.DataCategoryModel == null)
                {
                    await Task.Delay(1000);
                    continue;
                }
                if (prevDataCategoryLastUpdated == ModelController.dataCategoryLastUpdated)
                {
                    await Task.Delay(1000);
                    continue;
                }

                prevDataCategoryLastUpdated = ModelController.dataCategoryLastUpdated;
                await AddCategoryToCategoryFlowLayoutPanel();
                await Task.Delay(1000);
            }
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

        public void cancelationEvent()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
