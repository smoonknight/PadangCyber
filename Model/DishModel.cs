using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Model
{
    public class DishModel : Model, IModel
    {
        public string uid { get; set; }
        public string categoryUid { get; set; }
        public string codeDish { get; set; }
        public string name { get; set; }
        public string unitPrice { get; set; }
        public string photoURL { get; set; }
        public string codeCategory { get; set; }

        public void LastUpdated(DateTime dateTime)
        {
            lastUpdated = dateTime;
        }
    }
}
