using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Model
{
    public class CategoryModel : Model, IModel
    {
        public string uid { get; set; }
        public string name { get; set; }
        public string codeCategory { get; set; }
        public string totalDish { get; set; }

        public void LastUpdated(DateTime dateTime)
        {
            lastUpdated = dateTime;
        }
    }

}
