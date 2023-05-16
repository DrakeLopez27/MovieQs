using System;
using TMDbLib;
using Newtonsoft;
using TMDbLib.Objects.General;
using MovieQs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.Search;
using Microsoft.AspNetCore.Http.Metadata;
using System.Collections.Generic;
using TMDbLib.Objects.Discover;
using Microsoft.VisualBasic;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Genres;

public class TDMB_Repo
{
    TMDbClient client;
    public string apiKey = "3e9eee4e5b5aaeee16b28198f2c7589b";

    public TDMB_Repo()
    {
        client = new TMDbClient(apiKey);
    }


    // To get a movie
    public MyMovie GetSomeMovie()
    {

        SearchContainer<SearchMovie> apiResults = client.SearchMovieAsync("a").Result;

       
        List<MyMovie> movieList = new List<MyMovie>();

        foreach (SearchMovie result in apiResults.Results)
        {
            MyMovie movie = new MyMovie()
            {
                Id = result.Id,
                Title = result.Title,
                Popularity= result.Popularity,
                Overview= result.Overview,
            };

            movieList.Add(movie);
        }

        Random rnd = new Random();
        var number = rnd.Next(0,movieList.Count-1);
        return movieList[number];


        
        
    }


   
   

   // to get list of movies in specific genres available from api
    public List<MyMovie> GetMoviesByName(string movieName)
    {
       
        SearchContainer<SearchMovie> apiresults = client.SearchMovieAsync(movieName).Result;

        List<MyMovie> movielist = new List<MyMovie>();

        foreach (SearchMovie result in apiresults.Results)
        {
            MyMovie movie = new MyMovie()
            {
                Id = result.Id,
                Title = result.Title,
                Popularity = result.Popularity,
                Overview = result.Overview,
            };

            movielist.Add(movie);
        }


        return movielist;

    }

    public List<MyMovie> GetTrendingMovies()
    {
        SearchContainer<SearchMovie> apiresults = client.GetTrendingMoviesAsync(TMDbLib.Objects.Trending.TimeWindow.Day).Result;

        List<MyMovie> movielist = new List<MyMovie>();

        foreach (SearchMovie result in apiresults.Results)
        {
            MyMovie movie = new MyMovie()
            {
                Id = result.Id,
                Title = result.Title,
                Popularity = result.Popularity,
                Overview = result.Overview,
            };

            movielist.Add(movie);
        }


        return movielist;
    }
    
    public List<MyMovie> GetPopularMovies()
    {
        SearchContainer<SearchMovie> apiresults = client.GetMoviePopularListAsync().Result;

        List<MyMovie> movielist = new List<MyMovie>();

        foreach (SearchMovie result in apiresults.Results)
        {
            MyMovie movie = new MyMovie()
            {
                Id = result.Id,
                Title = result.Title,
                Popularity = result.Popularity,
                Overview = result.Overview,
            };

            movielist.Add(movie);
        }


        return movielist;
    }

   


}





//public List<MyMovie> GetMoviesByGenre(string genre)
//{
//    IEnumerable<int> genreidlist = new List<int>();

//    SearchContainer<SearchMovie> apiresults = client.SearchMovieAsync(genre).Result;

//    List<MyMovie> movielist = new List<MyMovie>();

//    foreach (SearchMovie result in apiresults.Results)
//    {
//        MyMovie movie = new MyMovie()
//        {
//            Id = result.Id,
//            Title = result.Title,
//            Popularity = result.Popularity,
//            Overview = result.Overview,
//        };

//        movielist.Add(movie);
//    }


//    return movielist;

//}









