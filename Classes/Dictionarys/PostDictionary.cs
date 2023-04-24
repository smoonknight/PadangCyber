using System;
using System.Collections.Generic;
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
            {"uniqueId", uniqueId }
        };

        public static Dictionary<string, string> Dish(string name, string amount, string categoryId, string uniqueId, string photoURL) => new Dictionary<string, string>()
        {
            {"name", name },
            {"amount", amount },
            {"categoryId", categoryId },
            {"uniqueId", uniqueId },
            {"photoURL", photoURL }
        };
    }

}
