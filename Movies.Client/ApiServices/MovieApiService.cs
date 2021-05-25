using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
  public class MovieApiService : IMovieApiService
  {
    public async Task<IEnumerable<Movie>> GetMovies()
    {
      var moviesList = new List<Movie>();
      moviesList.Add(new Movie
      {
        Id = 1,
        Genre = "Classics",
        Title = "Moste",
        Rating = "9.2",
        ImageUrl = "images/src",
        ReleaseDate = DateTime.Now,
        Owner = "micke"
      });

      return await Task.FromResult(moviesList);
    }

    public Task<Movie> CreateMovie(Movie movie)
    {
      throw new NotImplementedException();
    }

    public Task DeleteMovie(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Movie> GetMovie(string id)
    {
      throw new NotImplementedException();
    }

    public Task<Movie> UpdateMovie(Movie movie)
    {
      throw new NotImplementedException();
    }
  }
}
