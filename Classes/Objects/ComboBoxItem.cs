using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Objects
{
    class ComboBoxItem : Object
    {
        public string uid;
        public string text;
        public string codeCategory;

        public ComboBoxItem(string _uid, string _codeCategory, string text)
        {
            this.uid = _uid;
            this.codeCategory = _codeCategory;
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
