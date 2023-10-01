
namespace PadangCyberApp.View.Forms
{
    partial class CreateDishForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeDishTextbox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.commonLabel6 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.commonLabel5 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.commonLabel4 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.codeDishCommonLabel = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.commonLabel2 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.commonLabel1 = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.dishPanel = new PadangCyberApp.View.Template.CustomPanel.DishPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CloseButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(516, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.SaveButton.Location = new System.Drawing.Point(145, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(136, 33);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Simpan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(136, 33);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Batalkan";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 15);
            this.panel2.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 15);
            this.progressBar.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 15);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 396);
            this.splitContainer1.SplitterDistance = 509;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.commonLabel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.commonLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.commonLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.codeDishCommonLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.codeDishTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.openFileButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.categoryComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.unitPriceTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.commonLabel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 396);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // codeDishTextbox
            // 
            this.codeDishTextbox.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDishTextbox.Location = new System.Drawing.Point(141, 82);
            this.codeDishTextbox.MaxLength = 6;
            this.codeDishTextbox.Name = "codeDishTextbox";
            this.codeDishTextbox.Size = new System.Drawing.Size(365, 30);
            this.codeDishTextbox.TabIndex = 4;
            this.codeDishTextbox.TextChanged += new System.EventHandler(this.UniqueIdTextbox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(141, 3);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(365, 30);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.openFileButton.Location = new System.Drawing.Point(141, 319);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(201, 28);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Pilih foto";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(141, 240);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(365, 31);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTextBox.Location = new System.Drawing.Point(141, 161);
            this.unitPriceTextBox.MaxLength = 6;
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(365, 30);
            this.unitPriceTextBox.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.commonLabel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 396);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dishPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 358);
            this.panel3.TabIndex = 1;
            // 
            // commonLabel6
            // 
            this.commonLabel6.AutoSize = true;
            this.commonLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLabel6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.commonLabel6.Location = new System.Drawing.Point(3, 316);
            this.commonLabel6.Name = "commonLabel6";
            this.commonLabel6.Size = new System.Drawing.Size(132, 80);
            this.commonLabel6.TabIndex = 14;
            this.commonLabel6.Text = "Foto hidangan";
            // 
            // commonLabel5
            // 
            this.commonLabel5.AutoSize = true;
            this.commonLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLabel5.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.commonLabel5.Location = new System.Drawing.Point(3, 237);
            this.commonLabel5.Name = "commonLabel5";
            this.commonLabel5.Size = new System.Drawing.Size(132, 79);
            this.commonLabel5.TabIndex = 13;
            this.commonLabel5.Text = "Kategori";
            // 
            // commonLabel4
            // 
            this.commonLabel4.AutoSize = true;
            this.commonLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLabel4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.commonLabel4.Location = new System.Drawing.Point(3, 158);
            this.commonLabel4.Name = "commonLabel4";
            this.commonLabel4.Size = new System.Drawing.Size(132, 79);
            this.commonLabel4.TabIndex = 12;
            this.commonLabel4.Text = "harga";
            // 
            // codeDishCommonLabel
            // 
            this.codeDishCommonLabel.AutoSize = true;
            this.codeDishCommonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeDishCommonLabel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDishCommonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.codeDishCommonLabel.Location = new System.Drawing.Point(3, 79);
            this.codeDishCommonLabel.Name = "codeDishCommonLabel";
            this.codeDishCommonLabel.Size = new System.Drawing.Size(132, 79);
            this.codeDishCommonLabel.TabIndex = 11;
            this.codeDishCommonLabel.Text = "Kode";
            // 
            // commonLabel2
            // 
            this.commonLabel2.AutoSize = true;
            this.commonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLabel2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.commonLabel2.Location = new System.Drawing.Point(3, 0);
            this.commonLabel2.Name = "commonLabel2";
            this.commonLabel2.Size = new System.Drawing.Size(132, 79);
            this.commonLabel2.TabIndex = 10;
            this.commonLabel2.Text = "Nama hidangan";
            // 
            // commonLabel1
            // 
            this.commonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLabel1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.commonLabel1.Location = new System.Drawing.Point(3, 0);
            this.commonLabel1.Name = "commonLabel1";
            this.commonLabel1.Size = new System.Drawing.Size(281, 32);
            this.commonLabel1.TabIndex = 0;
            this.commonLabel1.Text = "Preview";
            this.commonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dishPanel
            // 
            this.dishPanel.codeCategory = null;
            this.dishPanel.codeDish = null;
            this.dishPanel.Location = new System.Drawing.Point(96, 105);
            this.dishPanel.Name = "dishPanel";
            this.dishPanel.nameDish = null;
            this.dishPanel.Size = new System.Drawing.Size(85, 115);
            this.dishPanel.TabIndex = 0;
            // 
            // CreateDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateDishForm";
            this.Load += new System.EventHandler(this.CreateDishForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox codeDishTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Template.CustomLabel.CommonLabel commonLabel1;
        private System.Windows.Forms.Panel panel3;
        private Template.CustomPanel.DishPanel dishPanel;
        private Template.CustomLabel.CommonLabel commonLabel6;
        private Template.CustomLabel.CommonLabel commonLabel5;
        private Template.CustomLabel.CommonLabel commonLabel4;
        private Template.CustomLabel.CommonLabel codeDishCommonLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private Template.CustomLabel.CommonLabel commonLabel2;
    }
}