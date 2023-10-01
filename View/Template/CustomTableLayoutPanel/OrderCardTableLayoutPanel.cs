using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PadangCyberApp.View.Template.CustomLabel;
using PadangCyberApp.Classes.Palette;
using PadangCyberApp.Classes.Strings;
using System.Drawing.Printing;
using PadangCyberApp.View.Forms;
using PadangCyberApp.Controller;

namespace PadangCyberApp.View.Template.CustomTableLayoutPanel
{
    internal class OrderCardTableLayoutPanel : TableLayoutPanel
    {
        Panel headerPanel = new Panel();
        Panel customerInfoPanel = new Panel();
        Panel orderInfoPanel = new Panel();
        PictureBox planPicture = new PictureBox();
        Label totalPriceLabel = new Label();
        Label nameCustomerLabel = new Label();
        Label numberTableLabel = new Label();
        CommonLabel planLabel = new CommonLabel();
        Label timeOrderLabel = new Label();
        Label numberOrderLabel = new Label();
        string customerId;
        public OrderCardTableLayoutPanel
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


            Size = new Size(200, 120);
            Margin = new Padding(10);
            BackColor = ColorPalette.whiteBackColor;

            #region header
            headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Margin = new Padding(0);
            headerPanel.BackColor = ColorPalette.secondaryColor;
            #endregion

            RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            Controls.Add(headerPanel, 0, 0);

            #region content header

            try
            {
                planPicture = new PictureBox();
                planPicture.Size = new Size(50, 50);
                planPicture.Dock = DockStyle.Left;
                planPicture.BackgroundImage = ImageDictionary.dine[plan];
                planPicture.BackgroundImageLayout = ImageLayout.Stretch;
                headerPanel.Controls.Add(planPicture);

            }
            catch (KeyNotFoundException)
            {
                CommonLabel planText = new CommonLabel(plan);
                planText.Dock = DockStyle.Left;
                planText.AutoSize = true;
                headerPanel.Controls.Add(planText);
            }

            totalPriceLabel = new CommonLabel(totalPrice, 12, FontStyle.Bold);
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            totalPriceLabel.ForeColor = ColorPalette.whiteForeColor;

            headerPanel.Controls.Add(totalPriceLabel);
            #endregion

            customerInfoPanel = new Panel();
            customerInfoPanel.Size = new Size(192, 21);

            RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            Controls.Add(customerInfoPanel, 0, 1);

            nameCustomerLabel = new CommonLabel(nameCustomer, 10, FontStyle.Bold);
            nameCustomerLabel.Dock = DockStyle.Left;
            nameCustomerLabel.Size = new Size(100, 21);
            nameCustomerLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameCustomerLabel.ForeColor = ColorPalette.blackForeColor;

            customerInfoPanel.Controls.Add(nameCustomerLabel);

            numberTableLabel = new CommonLabel(numberTable, 10, FontStyle.Bold);
            numberTableLabel.Dock = DockStyle.Right;
            numberTableLabel.Size = new Size(50, 21);
            numberTableLabel.TextAlign = ContentAlignment.MiddleRight;
            numberTableLabel.ForeColor = ColorPalette.blackForeColor;

            customerInfoPanel.Controls.Add(numberTableLabel);

            planLabel = new CommonLabel(plan, 9);
            planLabel.Size = new Size(191, 18);
            planLabel.ForeColor = ColorPalette.blackForeColor;

            RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            Controls.Add(planLabel, 0, 2);

            orderInfoPanel = new Panel();
            orderInfoPanel.Size = new Size(192, 21);

            RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            Controls.Add(orderInfoPanel, 0, 3);

            timeOrderLabel = new CommonLabel(timeOrder, 9);
            timeOrderLabel.Dock = DockStyle.Left;
            timeOrderLabel.Size = new Size(100, 21);
            timeOrderLabel.TextAlign = ContentAlignment.MiddleLeft;
            timeOrderLabel.ForeColor = ColorPalette.blackForeColor;

            orderInfoPanel.Controls.Add(timeOrderLabel);

            numberOrderLabel = new CommonLabel(numberQueue, 9);
            numberOrderLabel.Dock = DockStyle.Right;
            numberOrderLabel.Size = new Size(50, 21);
            numberOrderLabel.TextAlign = ContentAlignment.MiddleRight;
            numberOrderLabel.ForeColor = ColorPalette.blackForeColor;

            orderInfoPanel.Controls.Add(numberOrderLabel);

            customerId = ID;

            ControlController.InheritanceAllControlForClickEvents(Controls, Submit_Click);
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(customerId);
            orderForm.ShowDialog();
        }

    }
}