﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClientRest.Models;
using ClientRest.Models.In;
using Hanssens.Net;
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
        gus,
        invoicebuys,
        invoicesells,
        login,
        products,
        productbuys,
        productsells,
        payment,
        roles,
        units,
        users,
        sellers,
        summaries,
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
            //var storage = new LocalStorage();
            string token;
            using (FileStream stream = new FileStream("token", FileMode.Open))
            {
                using(BinaryReader reader = new BinaryReader(stream))
                {
                    token = reader.ReadString();
                }
            }
            //token = File.ReadAllText("token.txt");
            request.Headers.Add("Authorization","bearer " + token);

            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
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

        public T postRequest<T,T2>(T2 item, controller controller)
        {
            //var storage = new LocalStorage();
            string token;
            using (FileStream stream = new FileStream("token", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    token = reader.ReadString();
                }
            }
            //request.Headers.Add("bearer", token);
            string a = JsonConvert.SerializeObject(item, Formatting.Indented);
            var byteData = Encoding.UTF8.GetBytes(a);
            endPoint = address + controller.ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint); 
            httpMethod = httpVerb.POST;
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";
            request.Headers.Add("Authorization","bearer " + token);
            using (var stream = request.GetRequestStream())
            {
                stream.Write(byteData, 0, byteData.Length);
            }
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            httpMethod = httpVerb.GET;
            return JsonConvert.DeserializeObject<T>(responseString);
            //return item;
        }

        public T postRequest<T, T2>(T2 item, controller controller, string parameters)
        {
            //var storage = new LocalStorage();
            string token;
            using (FileStream stream = new FileStream("token", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    token = reader.ReadString();
                }
            }
            //request.Headers.Add("bearer", token);
            string a = JsonConvert.SerializeObject(item, Formatting.Indented);
            var byteData = Encoding.UTF8.GetBytes(a);
            endPoint = address + controller.ToString() + parameters;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            httpMethod = httpVerb.POST;
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "bearer " + token);
            using (var stream = request.GetRequestStream())
            {
                stream.Write(byteData, 0, byteData.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            httpMethod = httpVerb.GET;
            return JsonConvert.DeserializeObject<T>(responseString);
            //return item;
        }

        public LoginResult postLogin(LoginModel item)
        {
            string a = JsonConvert.SerializeObject(item, Formatting.Indented);
            var byteData = Encoding.UTF8.GetBytes(a);
            endPoint = address + "login";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            httpMethod = httpVerb.POST;
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";
            using (var stream = request.GetRequestStream())
            {
                stream.Write(byteData, 0, byteData.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            httpMethod = httpVerb.GET;
            return JsonConvert.DeserializeObject<LoginResult>(responseString);
            //return item;
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

        /// <summary>
        /// Returns data from server as object of given type. 
        /// </summary>
        /// <typeparam name="T">Expected type of returned object.</typeparam>
        /// <param name="controller">Name of controller.</param>
        /// <returns>Object of T type created from JSON.</returns>
        public T getRequest<T>(controller controller)
        {
            endPoint = address + controller.ToString();
            return JsonDeserialize<T>(makeRequest());
        }

        /// <summary>
        /// Returns data from server as object of given type.
        /// Used when HTTP method has additional route.
        /// E.g. .../api/ControllerName/AdditionalRoute 
        /// </summary>
        /// <typeparam name="T">Expected type of returned object.</typeparam>
        /// <param name="controller">Name of controller.</param>
        /// <param name="parameter">Additional routing.</param>
        /// <returns>Object of T type created from JSON.</returns>
        public T getRequest<T>(controller controller, string parameter)
        {
            endPoint = address + controller.ToString() + parameter;
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
