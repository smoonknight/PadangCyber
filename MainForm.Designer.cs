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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.dashboardUserControl1 = new PadangCyberApp.View.UserControls.DashboardUserControl();
            this.orderUserControl1 = new PadangCyberApp.View.UserControls.OrderUserControl();
            this.inventoryUserControl1 = new PadangCyberApp.View.UserControls.InventoryUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.InventoryButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ReportButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DashboardButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OrderButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(123, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryButton.FlatAppearance.BorderSize = 0;
            this.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InventoryButton.Location = new System.Drawing.Point(279, 3);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(132, 38);
            this.InventoryButton.TabIndex = 24;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReportButton.Location = new System.Drawing.Point(417, 3);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(134, 38);
            this.ReportButton.TabIndex = 23;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // DashboardButton
            // 
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DashboardButton.Location = new System.Drawing.Point(3, 3);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(132, 38);
            this.DashboardButton.TabIndex = 21;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OrderButton.Location = new System.Drawing.Point(141, 3);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(132, 38);
            this.OrderButton.TabIndex = 14;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dashboardUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 50);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(800, 400);
            this.dashboardUserControl1.TabIndex = 1;
            // 
            // orderUserControl1
            // 
            this.orderUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.orderUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderUserControl1.Location = new System.Drawing.Point(0, 0);
            this.orderUserControl1.Name = "orderUserControl1";
            this.orderUserControl1.Size = new System.Drawing.Size(800, 450);
            this.orderUserControl1.TabIndex = 2;
            // 
            // inventoryUserControl1
            // 
            this.inventoryUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.inventoryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryUserControl1.Location = new System.Drawing.Point(0, 50);
            this.inventoryUserControl1.Name = "inventoryUserControl1";
            this.inventoryUserControl1.Size = new System.Drawing.Size(800, 400);
            this.inventoryUserControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventoryUserControl1);
            this.Controls.Add(this.dashboardUserControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.orderUserControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private View.UserControls.DashboardUserControl dashboardUserControl1;
        private View.UserControls.OrderUserControl orderUserControl1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button InventoryButton;
        private View.UserControls.InventoryUserControl inventoryUserControl1;
    }
}