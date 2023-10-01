using PadangCyberApp.Classes.Animate;
using PadangCyberApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.View.Forms
{
    public partial class NotificationForm : Form
    {
        private string notificationMessage;
        private int countdownInSecond;

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public NotificationForm(string message)
        {
            InitializeComponent();

            notificationMessage = message;
        }

        private async void NotificationForm_Load(object sender, EventArgs e)
        {
            await FormAnimate.fadeIn(this);
            notificationCommonLabel.Text = notificationMessage;
            countdownInSecond = 2;
            NotificationCloser();
            ControlController.InheritanceAllControlForMouseHoverEvents(Controls, MouseHoverEvent);
        }

        private async void NotificationCloser()
        {
            countdownInSecond = 2;
            try
            {
                while (countdownInSecond > 0)
                {
                    await Task.Delay(1000, cancellationTokenSource.Token);
                    countdownInSecond -= 1;
                }
                await FormAnimate.fadeOut(this);
                Close();
            }
            catch (TaskCanceledException)
            {
                cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private void MouseHoverEvent(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            NotificationCloser();
        }
    }
}
