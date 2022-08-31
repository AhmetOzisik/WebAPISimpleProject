using Microsoft.AspNetCore.Mvc;
using ModelLayer.Entities;
using ModelLayer.OrderEntities;
using Newtonsoft.Json;
using Serilog;
using System.Diagnostics;
using System.Net;
using System.Text.Json;
using WebMVCProject.Models;


namespace WebMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetDataFromApi()
        
        
        {
            //using HttpClient client = new()
            //{
            //    BaseAddress = new Uri("https://northwind.now.sh/")
            //};
            //var shipadres = new ShipAddress()
            //{
            //    Street = "zafermahalle",
            //    City = "BUrsa",
            //    Region = "WER",
            //    //PostalCode = "85796",
            //    Country = "usa"

            //};

            //var Order = new Orders()
            //{
            //    Id = 196316,
            //    CustomerId = "aksulu",
            //    EmployeeId = 16,
            //    OrderDate = "1963-16-16 00:00:00.000",
            //    RequiredDate = "1963-16-16 00:00:00.000",
            //    ShippedDate = "1963-16-16 00:00:00.000",
            //    ShipVia = 16,
            //    Freight = 16.00,
            //    ShipName = "aksulu",
            //};


            //List<Orders>? orders = await client.GetFromJsonAsync<List<Orders>>("api/orders/");


            //var data = JsonConvert.SerializeObject(Order);
            //var content = new StringContent(data);
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //await client.PostAsync("api/orders/", content);



            //return View(orders);

            //string url = "https://northwind.now.sh/api/orders";

            //HttpWebRequest? httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
            //string json = "";
            //using (HttpWebResponse? response = httpWebRequest.GetResponse() as HttpWebResponse)
            //{
            //    StreamReader r = new StreamReader(response.GetResponseStream());
            //    json = r.ReadToEnd();
            //}
            //var model = System.Text.Json.JsonSerializer.Deserialize<List<Orders>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            //return View(model);

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response = await client.GetAsync("api/orders");
            string result = await response.Content.ReadAsStringAsync();
            List<Orders>? resultcontent = JsonConvert.DeserializeObject<List<Orders>>(result);
            return View(resultcontent);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}