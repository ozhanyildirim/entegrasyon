using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace ConsoleApp2
{  
    class Program
    {
        static void Main(string[] args)
        {
           RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response;
                client.BaseAddress = new Uri("https://api.payjinn.com/gateway/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var user = "TEST0001";
                var password = "12345678";
                var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64String);
                
                // post json
                Console.WriteLine("POST");

                var model1 = new Model  // model classındaki verileri alıyoruz
                {
                    transferAmount = new transferAmount
                    {
                        value = "118.80",
                        currency = "EUR"
                    },
                    clientNotificationURL = "https://api.payjinn.com/gateway/notification",
                    clientSuccessURL = "https://api.payjinn.com/gateway/success",
                    clientOnPaymentReceivedURL = "https://api.payjinn.com/gateway/received",
                    languageCode = "_EN",
                    paymentCode = "PAYJINN",
                    bookingId = "1",
                    clientOrderCode = "sadfasdf",
                };
                string json = JsonConvert.SerializeObject(model1);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = "https://api.payjinn.com/gateway/payments";
                response = await client.PostAsync(url, data);
                string result = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine("\n****************************************************************\n");
                 Console.WriteLine(result);
             

                Console.WriteLine("\n****************************************************************");

                //get json
                string a = result.Substring(110, 24);
                var urla = "https://api.payjinn.com/gateway/payments/"+a;

                Console.WriteLine("GET");
                Console.WriteLine("\n****************************************************************\n");

                if (response.IsSuccessStatusCode)
                {
                    var content = await client.GetStringAsync(urla);
                    Console.WriteLine(content);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(response);
                    Console.WriteLine("veri alınamadı");
                }
            }
        }
    }
}
