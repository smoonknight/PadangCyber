using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PadangCyberApp.View.Template.TextLabel;
using PadangCyberApp.Classes.Palette;
using System.Drawing.Printing;
using PadangCyberApp.Properties;

namespace PadangCyberApp.View.Template.CustomButton
{
    internal class OrderBox
    {
        public TableLayoutPanel Create
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
            TableLayoutPanel mainTableLayoutPanel;
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

            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Size = new Size(200, 120);
            mainTableLayoutPanel.BackColor = ColorPalette.whiteBackColor;

            #region header
            headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Margin = new Padding(0);
            headerPanel.BackColor = ColorPalette.secondaryColor;
            #endregion

            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            mainTableLayoutPanel.Controls.Add(headerPanel, 0, 0);

            #region content header
            planPicture = new PictureBox();
            planPicture.Size = new Size(50, 50);
            planPicture.Dock = DockStyle.Left;
            planPicture.BackgroundImage = Resources.table;
            planPicture.BackgroundImageLayout = ImageLayout.Stretch;
  
            headerPanel.Controls.Add(planPicture);

            totalPriceLabel = CommonLabel.Create(totalPrice, 12, FontStyle.Bold);
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            totalPriceLabel.ForeColor = ColorPalette.whiteForeColor;

            headerPanel.Controls.Add(totalPriceLabel);
            #endregion

            customerInfoPanel = new Panel();
            customerInfoPanel.Size = new Size(192, 21);

            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            mainTableLayoutPanel.Controls.Add(customerInfoPanel, 0, 1);

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

            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            mainTableLayoutPanel.Controls.Add(planLabel, 0, 2);

            orderInfoPanel = new Panel();
            orderInfoPanel.Size = new Size(192, 21);

            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            mainTableLayoutPanel.Controls.Add(orderInfoPanel, 0, 3);

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

            mainTableLayoutPanel.Tag = ID;

            mainTableLayoutPanel.Click += new EventHandler(Submit_Click);
            return mainTableLayoutPanel;
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            TableLayoutPanel tableLayoutPanel = sender as TableLayoutPanel;

            OrderForm orderForm = new OrderForm(tableLayoutPanel.Tag.ToString());
            orderForm.ShowDialog();
        }
    }
}
