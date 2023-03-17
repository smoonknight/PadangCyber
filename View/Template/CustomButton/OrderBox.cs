using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PadangCyberApp.View.Template.TextLabel;
using PadangCyberApp.Classes.Palette;

namespace PadangCyberApp.View.Template.CustomButton
{
    internal class OrderBox
    {
        public static FlowLayoutPanel Create
        (
            string ID,
            string plan, 
            string totalPrice,
            string nameCustomer,
            string numberTable,
            string timeOrder,
            string numberQueue
        )
        {
            FlowLayoutPanel mainFlowLayoutPanel;
            Panel headerPanel;
            Panel customerInfoPanel;
            Panel orderInfoPanel;
            PictureBox planPicture;
            Label totalPriceLabel;
            Label nameCustomerLabel;
            Label numberTableLabel;
            Label planLabel;
            Label timeOrderLabel;
            Label numberOrderLabel;

            mainFlowLayoutPanel = new FlowLayoutPanel();
            mainFlowLayoutPanel.Size = new Size(200, 120);
            #region header
            headerPanel = new Panel();
            headerPanel.Size = new Size(190, 50);
            headerPanel.BackColor = ColorPalette.secondaryColor;
            #endregion
            mainFlowLayoutPanel.Controls.Add(headerPanel);

            planPicture = new PictureBox();
            planPicture.Size = new Size(50, 50);
            planPicture.Dock = DockStyle.Left;
            planPicture.BackColor = ColorPalette.secondaryColor;
  
            headerPanel.Controls.Add(planPicture);

            totalPriceLabel = CommonLabel.Create(totalPrice, 12, FontStyle.Bold);
            totalPriceLabel.Size = new Size(120, 50);
            totalPriceLabel.Dock = DockStyle.Right;
            totalPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            totalPriceLabel.ForeColor = ColorPalette.whiteForeColor;

            headerPanel.Controls.Add(totalPriceLabel);

            customerInfoPanel = new Panel();
            customerInfoPanel.Size = new Size(192, 21);

            mainFlowLayoutPanel.Controls.Add(customerInfoPanel);

            nameCustomerLabel = CommonLabel.Create(nameCustomer, 10, FontStyle.Bold);
            nameCustomerLabel.Dock = DockStyle.Left;
            nameCustomerLabel.Size = new Size(100, 21);
            nameCustomerLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameCustomerLabel.ForeColor = ColorPalette.blackForeColor;

            customerInfoPanel.Controls.Add(nameCustomerLabel);

            numberTableLabel = CommonLabel.Create(numberTable, 10, FontStyle.Bold);
            numberTableLabel.Dock = DockStyle.Right;
            numberTableLabel.Size = new Size(50, 21);
            numberTableLabel.TextAlign = ContentAlignment.MiddleRight;
            numberTableLabel.ForeColor = ColorPalette.blackForeColor;

            customerInfoPanel.Controls.Add(numberTableLabel);

            planLabel = CommonLabel.Create(plan, 9);
            planLabel.Size = new Size(191, 18);
            planLabel.ForeColor = ColorPalette.blackForeColor;

            mainFlowLayoutPanel.Controls.Add(planLabel);

            orderInfoPanel = new Panel();
            orderInfoPanel.Size = new Size(192, 21);

            mainFlowLayoutPanel.Controls.Add(orderInfoPanel);

            timeOrderLabel = CommonLabel.Create(timeOrder, 9);
            timeOrderLabel.Dock = DockStyle.Left;
            timeOrderLabel.Size = new Size(100, 21);
            timeOrderLabel.TextAlign = ContentAlignment.MiddleLeft;
            timeOrderLabel.ForeColor = ColorPalette.blackForeColor;

            orderInfoPanel.Controls.Add(timeOrderLabel);

            numberOrderLabel = CommonLabel.Create(numberQueue, 9);
            numberOrderLabel.Dock = DockStyle.Right;
            numberOrderLabel.Size = new Size(50, 21);
            numberOrderLabel.TextAlign = ContentAlignment.MiddleRight;
            numberOrderLabel.ForeColor = ColorPalette.blackForeColor;

            orderInfoPanel.Controls.Add(numberOrderLabel);

            mainFlowLayoutPanel.Tag = ID;

            mainFlowLayoutPanel.Click += new EventHandler(Submit_Click);

            return mainFlowLayoutPanel;
        }

        public static void Submit_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = sender as FlowLayoutPanel;

            flowLayoutPanel.Size = new Size(122, 222);
        }
    }
}
