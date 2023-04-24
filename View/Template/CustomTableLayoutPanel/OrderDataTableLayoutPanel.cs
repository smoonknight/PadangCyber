using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PadangCyberApp.Classes.Palette;
using PadangCyberApp.View.Template.CustomLabel;

namespace PadangCyberApp.View.Template.CustomTableLayoutPanel
{
    class OrderDataTableLayoutPanel : TableLayoutPanel
    {
        public OrderDataTableLayoutPanel(string quantity, string unitPrice, string unitName, string totalPrice)
        {
            Controls.Clear();
            Dock = DockStyle.Top;
            Size = new Size(455, 35);

            CommonLabel orderQuantityLabel = new CommonLabel(quantity, 12);
            orderQuantityLabel.Dock = DockStyle.Fill;
            orderQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderQuantityLabel.BackColor = ColorPalette.secondaryColor;
            orderQuantityLabel.ForeColor = ColorPalette.whiteForeColor;
            orderQuantityLabel.AutoSize = false;

            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            Controls.Add(orderQuantityLabel, 0, 0);

            CommonLabel unitPriceLabel = new CommonLabel($"Rp. {unitPrice}", 12);
            unitPriceLabel.Dock = DockStyle.Fill;
            unitPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            unitPriceLabel.AutoSize = false;

            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            Controls.Add(unitPriceLabel, 1, 0);

            CommonLabel unitNameLabel = new CommonLabel(unitName, 12);
            unitNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            unitNameLabel.Dock = DockStyle.Fill;
            unitNameLabel.AutoEllipsis = true;

            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Controls.Add(unitNameLabel, 2, 0);

            CommonLabel orderTotalPriceLabel = new CommonLabel($"Rp. {totalPrice}", 12);
            orderTotalPriceLabel.Dock = DockStyle.Fill;
            orderTotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderTotalPriceLabel.AutoSize = false;

            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            Controls.Add(orderTotalPriceLabel, 3, 0);

            Button editButton = new Button();
            editButton.Dock = DockStyle.Fill;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.Image = Properties.Resources.Logo_PadangCyber;

            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            Controls.Add(editButton, 4, 0);

            Button deleteButton = new Button();
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Image = Properties.Resources.Logo_PadangCyber;

            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            Controls.Add(deleteButton, 5, 0);
        }

    }
}
