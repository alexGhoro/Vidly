using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
  public class MovieFormViewModel
  {
    public IEnumerable<Genre> Genres { get; set; }

    public Movie Movie { get; set; }

    [Display(Name = "Number in Stock")]
    [Range(1, 20)]
    [Required]
    public byte? NumberInStock { get; set; }

    public string Title
    {
      get
      {
        return Movie.Id != 0 ? "Edit Movie" : "New Movie";
      }
    }

    public MovieFormViewModel()
    {
      var movie = new Movie
      {
        Id = 0
      };
      Movie = movie;
    }

    public MovieFormViewModel(Movie movie)
    {
      Movie.Id = movie.Id;
      Movie.Name = movie.Name;
      Movie.ReleaseDate = movie.ReleaseDate;
      Movie.NumberInStock = movie.NumberInStock;
      Movie.GenreId = movie.GenreId;
    }
  }
}