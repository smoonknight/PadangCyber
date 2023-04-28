using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadangCyberApp.Classes.Animate;
using PadangCyberApp.Classes.Palette;
using PadangCyberApp.Classes.Points;
using PadangCyberApp.Properties;

namespace PadangCyberApp.View.Forms
{
    public partial class AlertForm : Form
    {
        bool _isSuccess;
        string _title;
        string _message;
        public AlertForm(bool isSuccess = true, string title = "Sukses",string message = "")
        {
            InitializeComponent();

            _isSuccess = isSuccess;
            _title = title;
            _message = message;
        }

        private async void AlertForm_Load(object sender, EventArgs e)
        {
            Location = LocationOnScreen.BottomRight(this);
            Color alertColor = _isSuccess ? ColorPalette.successAlertColor : ColorPalette.failedAlertColor;

            AlertPictureBox.Image = _isSuccess ? Resources._checked : Resources.failed;
            ConfirmButton.BackColor = alertColor;
            

            titleCommonLabel.Text = _title;
            messageCommonLabel.Text = _message;
            await FormAnimate.fadeIn(this);

            await Task.Delay(3000);
            await FormAnimate.fadeOut(this);
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
