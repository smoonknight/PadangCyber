using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing;
using System.IO;
using PadangCyberApp.Classes.Strings;
using System.Net.Http.Headers;

namespace PadangCyberApp.Controller
{
    class WebServiceController
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> Post(string URL, Dictionary<string, string> values)
        {
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(URL, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public static async Task<string> Post(string URL, Dictionary<string, string> values, byte[] imageByte)
        {
            var content = new MultipartFormDataContent();
            
            foreach (KeyValuePair<string, string> value in values)
            {
                content.Add(new StringContent(value.Key), value.Value);
            }
            ByteArrayContent imageContent = new ByteArrayContent(imageByte);
            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
            content.Add(imageContent, "image", "image.png");

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

        public static async Task<string> Delete(string URL)
        {
            var response = await client.DeleteAsync(URL);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

        public static async Task<Stream> StreamImage(string URL)
        {
            var response = await client.GetAsync(URL);
            return await response.Content.ReadAsStreamAsync();
        }
    }
}
