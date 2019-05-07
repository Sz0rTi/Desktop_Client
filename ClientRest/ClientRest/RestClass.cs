using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        invoices,
        products,
        productsinorder,
        taxstages
    }
    class RestClass
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string address { get; set; }


        public RestClass()
        {
            address = "https://localhost:44361/api/";
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

        public Test postRequest(Test item)
        {
            string a = JsonConvert.SerializeObject(item);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            httpMethod = httpVerb.POST;
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";
            using(StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(a);
                sw.Flush();
                sw.Close();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            httpMethod = httpVerb.GET;
            return item;
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
    }
}
