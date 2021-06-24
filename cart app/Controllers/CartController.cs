using cart_app.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace cart_app.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()

        {
            var productModel = new ProductModel();
            ViewBag.products = productModel.FindAll();


            return View();
        }


        public Product GetApiData()
        {

        //    // JavaScriptSerializer ser = new JavaScriptSerializer();
        //    // List<ProductModel> jsonList = ser.Deserialize<List<ProductModel>>(json);
        //    // //END

        WebClient client1 = new WebClient();
        string username = "TEST0001";
        string password = "12345678";
        string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
        client1.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

            // post json

            //    var data = new StringContent(json, Encoding.UTF8, "application/json");
            // var url = "https://api.payjinn.com/gateway/payments";
            //                string result = response.Content.ReadAsStringAsync().Result;


            var apiUrl = "https://api.payjinn.com/gateway/payments/10000040009-038114174184";

        //Connect API
        Uri url = new Uri(apiUrl);
        string json = client1.DownloadString(url);
        //string json = await client.GetStringAsync(urla);

        //END

        //JSON Parse START
        JsonConvert.SerializeObject(json);
        Product jsonList = JsonConvert.DeserializeObject<Product>(json);
        return jsonList;
            
        }


    }
}
