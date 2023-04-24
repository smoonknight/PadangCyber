using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Objects
{
    class ComboBoxItem : Object
    {
        public string Value;
        public string Text;
        public string uniqueId;
        public ComboBoxItem(string value, string _uniqueId, string text)
        {
            Value = value;
            uniqueId = _uniqueId;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
