using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Strings
{
    class PostDictionary
    {
        public static Dictionary<string, string> Category(string name, string uniqueId) => new Dictionary<string, string>()
        {
            {"name", name},
            {"codeCategory", uniqueId }
        };

        public static Dictionary<string, string> Dish(string categoryUid, string codeDish, string name, string unitPrice) => new Dictionary<string, string>()
        {
            {"categoryUid", categoryUid },
            {"codeDish", codeDish },
            {"name", name },
            {"unitPrice", unitPrice }
        };
    }

}
