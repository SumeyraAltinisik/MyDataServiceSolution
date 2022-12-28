using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using MyDataService.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async  Task<IActionResult> Index()
        {
            List<Gubudik> Listem = new List<Gubudik>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5223/store/Albums"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Listem = JsonConvert.DeserializeObject<List<Gubudik>>(apiResponse);
                }
            }

            return View(Listem);
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