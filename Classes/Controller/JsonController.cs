using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using PadangCyberApp.Model;

namespace PadangCyberApp.Classes.Controller
{
    class JsonController
    {
        public async static Task<T> JsonConvertDeserializeAsync<T>(string json)
        {
            T model = await new TaskFactory().StartNew(() => JsonConvert.DeserializeObject<T>(json));
            return model;
        }

        public static bool isJsonNull(string json)
        {
            if (json == "{}")
            {
                return true;
            }
            return false;
        }
    }
}
