using PadangCyberApp.Properties;
using PadangCyberApp.View.Template.CustomLabel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.View.Template.CustomPanel
{
    class DishPanel : Panel
    {
        public Button dishButton = new Button();
        public CommonLabel nameDishCommonLabel = new CommonLabel(8);
        public CommonLabel codeDishCommonLabel = new CommonLabel(8);
        public DishPanel()
        {
            Margin = new Padding(3);
            Padding = new Padding(0);
            Size = new Size(85, 115);

            dishButton.BackColor = Color.White;
            dishButton.BackgroundImage = Resources.dish;
            dishButton.BackgroundImageLayout = ImageLayout.Stretch;
            dishButton.Size = new Size(85, 85);

            nameDishCommonLabel.Margin = new Padding(0);
            nameDishCommonLabel.Size = new Size(15, 15);
            nameDishCommonLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameDishCommonLabel.Dock = DockStyle.Bottom;

            codeDishCommonLabel.Margin = new Padding(0);
            codeDishCommonLabel.Size = new Size(15, 15);
            codeDishCommonLabel.TextAlign = ContentAlignment.MiddleCenter;
            codeDishCommonLabel.Dock = DockStyle.Bottom;

            Controls.Add(dishButton);
            Controls.Add(nameDishCommonLabel);
            Controls.Add(codeDishCommonLabel);
        }
    }
}
