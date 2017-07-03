using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    public ApplicationDbContext _context;

    public MoviesController()
    {
      _context = new ApplicationDbContext();
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }  

    public ViewResult Index()
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();
      return View(movies);    
    }

    public ActionResult New()
    {
      var genres = _context.Genres.ToList();
      var viewModel = new MovieFormViewModel
      {
        Movie = new Movie
        {
          DateAdded = DateTime.Now
        },
        Genres = genres
      };
      return View("MovieForm", viewModel);
    }

    public ActionResult Edit(int id)
    {
      var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

      if (movie == null)
        return HttpNotFound();

      var viewModel = new MovieFormViewModel
      {
        Movie = movie,
        Genres = _context.Genres.ToList()
      };
      return View("MovieForm", viewModel);
    }

    [HttpPost]
    public ActionResult Save(Movie movie)
    {
      if (movie.Id == 0)
      {
        var genre = _context.Genres.Single(c => c.Id == movie.GenreId);
        movie.Genre = genre;
        _context.Movies.Add(movie);
      }
      else
      {
        var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
        movieInDb.Name = movie.Name;
        movieInDb.ReleaseDate = movie.ReleaseDate;
        movieInDb.DateAdded = movie.DateAdded;
        movieInDb.NumberInStock = movie.NumberInStock;
        movieInDb.Genre = movie.Genre;
      }


      _context.SaveChanges();

      return RedirectToAction("Index", "Movies");
    }

    public ActionResult Details(int id)
    {
      var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

      if (movie == null)
        return HttpNotFound();

      return View(movie);
    }


  }
}