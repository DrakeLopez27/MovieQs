using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace MovieQs.Models.Repo
{
    public class TDMB_URL_Repo
    {
        HttpClient client;

        public TDMB_URL_Repo()
        {
            client = new HttpClient();
        }




        public List<MyMovie> GetMoviesByGenre(int id)
        {
          var url = "https://www.themoviedb.org/discover/movie?sort_by=with_genres.desc/api_key=3e9eee4e5b5aaeee16b28198f2c7589b";
          var client = new HttpClient();
          var response = client.GetAsync(url);
          var responseBody = response.Result;

          
            List<MyMovie> moviesByGenre= new List<MyMovie>();

            moviesByGenre.Add(new MyMovie
            {
                
                Title = response.Result.ToString(),
                Overview= response.Result.ToString(),

            });
            return moviesByGenre;
            
            
            

        }
        //public List<MyMovie> GetMoviesByGenre(string genre)
        //{
        //    IEnumerable<int> genreIdList = new List<int>();
        //    // SearchContainer<SearchMovie> apiResults = client.DiscoverMoviesAsync().IncludeWithAnyOfGenre(genreId);

        //    SearchContainer<SearchMovie> apiResults = client.SearchMovieAsync(genre).Result;

        //    List<MyMovie> movieList = new List<MyMovie>();

        //    foreach (SearchMovie result in apiResults.Results)
        //    {
        //        MyMovie movie = new MyMovie()
        //        {
        //            Id = result.Id,
        //            Title = result.Title,
        //            Popularity = result.Popularity,
        //            Overview = result.Overview,
        //        };

        //        movieList.Add(movie);
        //    }


        //    return movieList;

        //}
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