using Microsoft.AspNetCore.Mvc;
using MovieQs.Models;
using MovieQs.Models.Repo;
using System.Reflection.Metadata.Ecma335;
using System.Web.Mvc;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace MovieQs.Controllers
{
    public class MovieListController : Controller
    {
        

        public IActionResult Index()
        {
            TDMB_Repo api = new TDMB_Repo();


            MovieListObject lists = new MovieListObject()
            {
                movies = null,
               
            };

            return View("Index", lists);
        }
        
        public IActionResult TrendingMovies()
        {
            TDMB_Repo api = new TDMB_Repo();

            List<MyMovie> movies = api.GetTrendingMovies();

            MovieListObject movieListObject = new MovieListObject()
            {
                movies = movies
            };

            return View("TrendingMovies", movieListObject);
        }
        
        public IActionResult PopularMovies()
        {
            TDMB_Repo api = new TDMB_Repo();

            List<MyMovie> movies = api.GetPopularMovies();

            MovieListObject movieListObject = new MovieListObject()
            {
                movies = movies
            };

            return View("PopularMovies", movieListObject);
        }
        
        
        

        public IActionResult ViewMoviesByName(string name)
        {
            //List<Movie> movies = new List<Movie>();

            TDMB_Repo apiResult = new TDMB_Repo();
            //TDMB_URL_Repo apiResult = new TDMB_URL_Repo();

            List<MyMovie> movies = apiResult.GetMoviesByName(name);
            



            MovieListObject movieListObject = new MovieListObject()
            {
                movies = movies

            };

               return View("ViewMoviesByName", movieListObject);  


            

            

        }

    }
}

