using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Shorten
{
    static class Shorten
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }

        static private string APIKey = "AIzaSyBdn297G_kq-kwdKTcUGP2Lms9JzKvA9qA";

        public struct Response
        {
            public string Kind { get; set; }
            public string ShortURL { get; set; }
            public string LongURL { get; set; }
        };

        private struct Request
        {
            public string longUrl { get; set; }
            public string key { get; set; }
        }

        static public Response Run(string longURL)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.googleapis.com/urlshortener/v1/url?key=" + APIKey);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var request = new Request{ longUrl = longURL };
                var requestJSON = JsonConvert.SerializeObject(request);

                streamWriter.Write(requestJSON);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Response response;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var responseJObject = (JObject)JsonConvert.DeserializeObject(result);

                response = new Response
                {
                    Kind = responseJObject["kind"].ToObject<string>(),
                    ShortURL = responseJObject["id"].ToObject<string>(),
                    LongURL = responseJObject["longUrl"].ToObject<string>()
                };
            }

            return response;
        }
    }
}
