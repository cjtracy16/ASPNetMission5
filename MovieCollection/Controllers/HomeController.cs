using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieFormContext movielogger)
        {
            _logger = logger;
            movieContext = movielogger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Rating = movieContext.Rating.ToList();
            ViewBag.Category = movieContext.Category.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie mr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(mr);
                movieContext.SaveChanges();

                return View("Confirmation", mr);
            }
            else
            {
                ViewBag.Rating = movieContext.Rating.ToList();
                ViewBag.Category = movieContext.Category.ToList();

                return View(mr);
            }
            
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Rating)
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
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

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Rating = movieContext.Rating.ToList();
            ViewBag.Category = movieContext.Category.ToList();

            var movie = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movieUpdate)
        {
            movieContext.Update(movieUpdate);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View("Delete", movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie mr)
        {
            movieContext.Responses.Remove(mr);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
