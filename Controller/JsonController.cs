using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using PadangCyberApp.Model;

namespace PadangCyberApp.Controller
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
            catch (Exception ex)
            {
                throw new Exception("Terjadi kesalahan saat melakukan deserialisasi JSON.\n" + json, ex);
            }
        }




        public static bool isJsonNull(string json)
        {
            if (json == "{}" || json == null)
            {
                return true;
            }

            return false;
        }
    }
}
