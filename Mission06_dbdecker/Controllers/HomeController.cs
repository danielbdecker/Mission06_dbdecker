using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_dbdecker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dbdecker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext movieContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MoviesContext someName)
        {
            _logger = logger;
            movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movie()
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movie(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(mr);
                movieContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View(mr);
            }
            
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

        public IActionResult MovieList ()
        {
            var movies = movieContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            //is this supposed to be R or r in responses??
            var movie = movieContext.responses.Single(x => x.MovieID == movieid);

            return View("Movie", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Update(mr);
                movieContext.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View("Movie", mr);
            }
        }

        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.responses.Single(x => x.MovieID == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            movieContext.responses.Remove(mr);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
