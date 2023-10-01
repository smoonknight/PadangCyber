
namespace PadangCyberApp.View.Forms
{
    partial class NotificationForm
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
            this.beutifyPanel1 = new PadangCyberApp.View.Template.CustomPanel.BeautifyPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.notificationCommonLabel = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.beutifyPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // beutifyPanel1
            // 
            this.beutifyPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.beutifyPanel1.BorderColor = System.Drawing.Color.Empty;
            this.beutifyPanel1.BorderRadius = 30;
            this.beutifyPanel1.BorderWidth = 3;
            this.beutifyPanel1.Controls.Add(this.tableLayoutPanel1);
            this.beutifyPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beutifyPanel1.Location = new System.Drawing.Point(0, 0);
            this.beutifyPanel1.Name = "beutifyPanel1";
            this.beutifyPanel1.Size = new System.Drawing.Size(600, 60);
            this.beutifyPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.notificationCommonLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // notificationCommonLabel
            // 
            this.notificationCommonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationCommonLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationCommonLabel.Location = new System.Drawing.Point(10, 10);
            this.notificationCommonLabel.Margin = new System.Windows.Forms.Padding(10);
            this.notificationCommonLabel.Name = "notificationCommonLabel";
            this.notificationCommonLabel.Size = new System.Drawing.Size(580, 40);
            this.notificationCommonLabel.TabIndex = 1;
            this.notificationCommonLabel.Text = "...";
            this.notificationCommonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 60);
            this.Controls.Add(this.beutifyPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 60);
            this.MinimumSize = new System.Drawing.Size(600, 60);
            this.Name = "NotificationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.beutifyPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Template.CustomPanel.BeautifyPanel beutifyPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Template.CustomLabel.CommonLabel notificationCommonLabel;
    }
}