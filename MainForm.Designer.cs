
namespace PadangCyberApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusCommonLabel = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.commonLabel2 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.createOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlPanel);
            this.panel1.Controls.Add(this.headerPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 470);
            this.panel1.TabIndex = 2;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(0, 44);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(800, 406);
            this.userControlPanel.TabIndex = 4;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.headerPanel.Controls.Add(this.headerTableLayoutPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 44);
            this.headerPanel.TabIndex = 3;
            // 
            // headerTableLayoutPanel
            // 
            this.headerTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.headerTableLayoutPanel.ColumnCount = 8;
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.headerTableLayoutPanel.Controls.Add(this.inventoryButton, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.dashboardButton, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.orderButton, 1, 0);
            this.headerTableLayoutPanel.Controls.Add(this.reportButton, 4, 0);
            this.headerTableLayoutPanel.Controls.Add(this.createOrder, 7, 0);
            this.headerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 1;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(800, 44);
            this.headerTableLayoutPanel.TabIndex = 4;
            // 
            // inventoryButton
            // 
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(180, 0);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(80, 44);
            this.inventoryButton.TabIndex = 8;
            this.inventoryButton.Text = "Persediaan";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(100, 0);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(80, 44);
            this.dashboardButton.TabIndex = 7;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "PadangCyber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderButton
            // 
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(260, 0);
            this.orderButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(80, 44);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Pesanan";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(340, 0);
            this.reportButton.Margin = new System.Windows.Forms.Padding(0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(80, 44);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "Laporan";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.statusCommonLabel);
            this.panel2.Controls.Add(this.commonLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 20);
            this.panel2.TabIndex = 5;
            // 
            // statusCommonLabel
            // 
            this.statusCommonLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusCommonLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCommonLabel.ForeColor = System.Drawing.Color.White;
            this.statusCommonLabel.Location = new System.Drawing.Point(54, 0);
            this.statusCommonLabel.Name = "statusCommonLabel";
            this.statusCommonLabel.Size = new System.Drawing.Size(245, 20);
            this.statusCommonLabel.TabIndex = 1;
            this.statusCommonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commonLabel2
            // 
            this.commonLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.commonLabel2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel2.ForeColor = System.Drawing.Color.White;
            this.commonLabel2.Location = new System.Drawing.Point(0, 0);
            this.commonLabel2.Name = "commonLabel2";
            this.commonLabel2.Size = new System.Drawing.Size(54, 20);
            this.commonLabel2.TabIndex = 0;
            this.commonLabel2.Text = "Status : ";
            this.commonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createOrder
            // 
            this.createOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createOrder.FlatAppearance.BorderSize = 0;
            this.createOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrder.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrder.Location = new System.Drawing.Point(643, 3);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(154, 38);
            this.createOrder.TabIndex = 10;
            this.createOrder.Text = "Buat pesanan";
            this.createOrder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerTableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.Panel panel2;
        private View.Template.CustomLabel.CommonLabel commonLabel2;
        private View.Template.CustomLabel.CommonLabel statusCommonLabel;
        private System.Windows.Forms.Button createOrder;
    }
}