﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PadangCyberApp.Classes.Controller
{
    class WebServiceController
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> Post(string URL, string name, string uniqueId)
        {
            var values = new Dictionary<string, string>
            {
                {"name",  name},
                {"uniqueId", uniqueId }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(URL, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public static async Task<string> Get(string URL)
        {
            var response = await client.GetAsync(URL);
            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}
