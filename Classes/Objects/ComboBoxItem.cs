using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Objects
{
    class ComboBoxItem : Object
    {
        public string value;
        public string text;
        public string uniqueId;
        public ComboBoxItem(string value, string _uniqueId, string text)
        {
            this.value = value;
            uniqueId = _uniqueId;
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
