using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PadangCyberApp.Classes.Palette;

namespace PadangCyberApp.View.Template.CustomTableLayoutPanel
{
    internal class OrderTableLayoutPanel
    {
        public static TableLayoutPanel Create(string quantity, string unitPrice, string unitName, string totalPrice)
        {
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Controls.Clear();
            mainTableLayoutPanel.Dock = DockStyle.Top;
            mainTableLayoutPanel.Size = new Size(455, 35);

            Label orderQuantityLabel = CustomLabel.CommonLabel.Create(quantity, 12);
            orderQuantityLabel.Dock = DockStyle.Fill;
            orderQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderQuantityLabel.BackColor = ColorPalette.secondaryColor;
            orderQuantityLabel.ForeColor = ColorPalette.whiteForeColor;
            orderQuantityLabel.AutoSize = false;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            mainTableLayoutPanel.Controls.Add(orderQuantityLabel, 0, 0);

            Label unitPriceLabel = CustomLabel.CommonLabel.Create($"Rp. {unitPrice}", 12);
            unitPriceLabel.Dock = DockStyle.Fill;
            unitPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            unitPriceLabel.AutoSize = false;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            mainTableLayoutPanel.Controls.Add(unitPriceLabel, 1, 0);

            Label unitNameLabel = CustomLabel.CommonLabel.Create(unitName, 12);
            unitNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            unitNameLabel.Dock = DockStyle.Fill;
            unitNameLabel.AutoEllipsis = true;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            mainTableLayoutPanel.Controls.Add(unitNameLabel, 2, 0);

            Label orderTotalPriceLabel = CustomLabel.CommonLabel.Create($"Rp. {totalPrice}", 12);
            orderTotalPriceLabel.Dock = DockStyle.Fill;
            orderTotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderTotalPriceLabel.AutoSize = false;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            mainTableLayoutPanel.Controls.Add(orderTotalPriceLabel, 3, 0);

            Button editButton = new Button();
            editButton.Dock = DockStyle.Fill;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.Image = Properties.Resources.Logo_PadangCyber;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            mainTableLayoutPanel.Controls.Add(editButton, 4, 0);

            Button deleteButton = new Button();
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Image = Properties.Resources.Logo_PadangCyber;

            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            mainTableLayoutPanel.Controls.Add(deleteButton, 5, 0);

            return mainTableLayoutPanel;
        }

        async void ModalLoader()
        {
            await Task.Run(() =>
            {

            });
        }

    }
}
