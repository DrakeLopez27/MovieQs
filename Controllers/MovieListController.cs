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


            

            


            //TDMB_Repo api = new TDMB_Repo();
            //List<MyGenre> genres = api.GetGenres();

            //MovieListObject lists = new MovieListObject()
            //{
            //    movies = actionMovies,
            //    genres = genres
            //};

            

           // return View("GetMoviesByName", lists);

        }

    }
}

//Action          28
//Adventure       12
//Animation       16
//Comedy          35
//Crime           80
//Documentary     99
//Drama           18
//Family          10751
//Fantasy         14
//History         36
//Horror          27
//Music           10402
//Mystery         9648
//Romance         10749
//Science Fiction 878
//TV Movie        10770
//Thriller        53
//War             10752
//Western         37

//List<MyMovie> actionMovies = apiResult.GetMoviesByGenre(28);
//List<MyMovie> adventureMovies = apiResult.GetMoviesByGenre(12);
//List<MyMovie> animationMovies = apiResult.GetMoviesByGenre(16);
//List<MyMovie> comedyMovies = apiResult.GetMoviesByGenre(35);
//List<MyMovie> crimeMovies = apiResult.GetMoviesByGenre(80);
//List<MyMovie> documentaryMovies = apiResult.GetMoviesByGenre(99);
//List<MyMovie> dramaMovies = apiResult.GetMoviesByGenre(18);
//List<MyMovie> familyMovies = apiResult.GetMoviesByGenre(10751);
//List<MyMovie> fantasyMovies = apiResult.GetMoviesByGenre(14);
//List<MyMovie> historyMovies = apiResult.GetMoviesByGenre(36);
//List<MyMovie> horrorMovies = apiResult.GetMoviesByGenre(27);
//List<MyMovie> musicMovies = apiResult.GetMoviesByGenre(10402);
//List<MyMovie> mysteryMovies = apiResult.GetMoviesByGenre(9648);
//List<MyMovie> romanceMovies = apiResult.GetMoviesByGenre(10749);
//List<MyMovie> scifiMovies = apiResult.GetMoviesByGenre(878);
//List<MyMovie> TvMovies = apiResult.GetMoviesByGenre(10770);
//List<MyMovie> thrillerMovies = apiResult.GetMoviesByGenre(53);
//List<MyMovie> warMovies = apiResult.GetMoviesByGenre(10752);
//List<MyMovie> westernMovies = apiResult.GetMoviesByGenre(37);

//foreach(MyMovie movie in actionMovies)
//{
//    MyMovie movieInfo = new MyMovie();
//    movieInfo.Title = movie.Title;
//    movieInfo.Id = movie.Id;
//    movieInfo.Popularity = movie.Popularity;
//    movieInfo.Overview = movie.Overview;
//    return View("Index", movieInfo);
//}

//TDMB_URL_Repo api = new TDMB_URL_Repo();
//List<MyMovie> movies = api.GetMoviesByGenre(28);