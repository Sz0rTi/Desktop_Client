using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClientRest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClientRest
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum controller
    {
        clients,
        categories,
        invoicebuys,
        invoicesells,
        products,
        productbuys,
        productsells,
        roles,
        units,
        users,
        sellers,
        taxstages
    }
    class RestClass
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string address { get; set; }


        public RestClass()
        {
            //address = "https://localhost:44361/api/";
            address = "https://localhost:5001/api/";
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponceValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("UPSIK");
                }

                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponceValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponceValue;
        }

        public T postRequest<T>(T item, controller controller)
        {
            string a = JsonConvert.SerializeObject(item, Formatting.Indented);
            var byteData = Encoding.ASCII.GetBytes(a);
            endPoint = address + controller.ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint); 
            httpMethod = httpVerb.POST;
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";
            using(var stream = request.GetRequestStream())
            {
                stream.Write(byteData, 0, byteData.Length);
                //sw.Write(a);
                //sw.Flush();
                //sw.Close();
            }
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            httpMethod = httpVerb.GET;
            return item;
        }

        public void post(Product p)
        {
            /*using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("https://localhost:44361/");
                var response = client.PostAsJsonAsync("api/products", p).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");   
            }*/

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44361/");
                var response = client.PostAsJsonAsync("api/products", p).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }

        }

        public T JsonDeserialize<T>(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public T getRequest<T>(controller controller)
        {
            endPoint = address + controller.ToString();
            return JsonDeserialize<T>(makeRequest());
        }

        public int intFromValue(string a)
        {
            int fid;
            bool parseOK = Int32.TryParse(a, out fid);
            return fid;
        }
    }
}
