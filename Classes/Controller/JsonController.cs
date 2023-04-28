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
            try
            {
                var deserialize = await new TaskFactory().StartNew(() => JsonConvert.DeserializeObject<T>(json));
                return deserialize;
            }
            catch
            {
            }
            return default(T);
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
