using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadangCyberApp.View.Template.CustomTableLayoutPanel;
using System.Windows.Forms;
using PadangCyberApp.Controller;
using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Model;
using PadangCyberApp.Interface;
using System.Threading;

namespace PadangCyberApp.View.UserControls
{
    public partial class DashboardUserControl : UserControl, IUserControl
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private async void DashboardUserControl_Load(object sender, EventArgs e)
        {
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            try
            {
                string json = await WebServiceController.Get(URLWebService.Get.customer);
                ModelController.DataCustomerModel = await JsonController.JsonConvertDeserializeAsync<CustomerModel[]>(json);
                Control[] controls = new Control[ModelController.DataCustomerModel.Length];

                int counter = 0;

                ListOrderFlowLayoutPanel.SuspendLayout();

                await Task.Run(() =>
                {
                    foreach (var customerModel in ModelController.DataCustomerModel)
                    {
                        // Mengecek apakah ada permintaan pembatalan
                        if (cancellationToken.IsCancellationRequested)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                        }

                        OrderCardTableLayoutPanel flowLayoutPanel = new OrderCardTableLayoutPanel(customerModel.uid, customerModel.plan, customerModel.totalPrice, customerModel.nameCustomer, customerModel.numberTable, customerModel.timeOrder, customerModel.numberQueue);
                        controls[counter] = flowLayoutPanel;
                        counter++;
                    }
                }, cancellationToken); // Menggunakan CancellationToken

                ListOrderFlowLayoutPanel.Controls.AddRange(controls);

                ListOrderFlowLayoutPanel.ResumeLayout();
            }
            catch (OperationCanceledException)
            {
            }
        }

        public void cancelationEvent()
        {
            cancellationTokenSource.Cancel();
        }
    }
}