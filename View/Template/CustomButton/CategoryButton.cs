using PadangCyberApp.Classes.Palette;
using PadangCyberApp.View.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadangCyberApp.View.Template.CustomPanel
{
    public class CategoryButton : Button
    {
        public string _uniqueId;
        public string _idTable;
        public CategoryButton(string uniqueId, string text, string idTable)
        {
            Text = text;
            _uniqueId = uniqueId;
            _idTable = idTable;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Century Schoolbook", 8.25f, FontStyle.Regular);
            AutoSize = true;
            BackColor = ColorPalette.whiteBackColor;
            ForeColor = ColorPalette.blackForeColor;
            FlatStyle = FlatStyle.Standard;
            Click += CategoryButton_Click;
        }

        void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryButton categoryButton = sender as CategoryButton;
            CategoryDescriptionForm categoryDescriptionForm = new CategoryDescriptionForm(categoryButton._uniqueId);
            categoryDescriptionForm.ShowDialog();
        }
    }
}
