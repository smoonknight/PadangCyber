
namespace PadangCyberApp.View.Forms
{
    partial class AlertForm
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
            this.AlertPictureBox = new System.Windows.Forms.PictureBox();
            this.titleCommonLabel = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.messageCommonLabel = new PadangCyberApp.View.Template.CustomLabel.CommonLabel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AlertPictureBox
            // 
            this.AlertPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.AlertPictureBox.Image = global::PadangCyberApp.Properties.Resources.failed;
            this.AlertPictureBox.Location = new System.Drawing.Point(12, 12);
            this.AlertPictureBox.Name = "AlertPictureBox";
            this.AlertPictureBox.Size = new System.Drawing.Size(50, 50);
            this.AlertPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlertPictureBox.TabIndex = 1;
            this.AlertPictureBox.TabStop = false;
            // 
            // titleCommonLabel
            // 
            this.titleCommonLabel.AutoSize = true;
            this.titleCommonLabel.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCommonLabel.Location = new System.Drawing.Point(82, 25);
            this.titleCommonLabel.Name = "titleCommonLabel";
            this.titleCommonLabel.Size = new System.Drawing.Size(177, 25);
            this.titleCommonLabel.TabIndex = 2;
            this.titleCommonLabel.Text = "commonLabel1";
            // 
            // messageCommonLabel
            // 
            this.messageCommonLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.messageCommonLabel.Location = new System.Drawing.Point(12, 69);
            this.messageCommonLabel.Margin = new System.Windows.Forms.Padding(0);
            this.messageCommonLabel.Name = "messageCommonLabel";
            this.messageCommonLabel.Size = new System.Drawing.Size(376, 58);
            this.messageCommonLabel.TabIndex = 3;
            this.messageCommonLabel.Text = "commonLabel2";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Maroon;
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 130);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(376, 36);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Oke";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 178);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.messageCommonLabel);
            this.Controls.Add(this.titleCommonLabel);
            this.Controls.Add(this.AlertPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlertPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AlertPictureBox;
        private Template.CustomLabel.CommonLabel titleCommonLabel;
        private Template.CustomLabel.CommonLabel messageCommonLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}