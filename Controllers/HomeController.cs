using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MovieQs.Models;
using System.Diagnostics;

namespace MovieQs.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetMovie()
        {
            var client = new HttpClient();
            var MoviesURL = "https://api.themoviedb.org/3/discover/movie/?api_key=3e9eee4e5b5aaeee16b28198f2c7589b";
            var Movies = client.GetStringAsync(MoviesURL).Result;

            return View(Movies);
        }

        public IActionResult ViewMovie()
        {
          
            var api = new TDMB_Repo();
            var movie = api.GetSomeMovie();

            
            return View("Index",movie);
         

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}