using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("Movies/Index")]
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Justice League", Id = 1 },
                new Movie {Name = "Batman Begins", Id = 2 }
            };
        }


    }
}