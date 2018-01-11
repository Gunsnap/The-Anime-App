using System;
using System.Collections.Generic;
using System.Diagnostics;
using Anime_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anime_Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(int id = 0)
        {
            List<Movie> Movies = new List<Movie>
            {
                new Movie()
                {
                    Name = "Die Hard",
                    Length = 130,
                    Year = new DateTime(1986, 1, 1),
                    Billede = "~/images/Die_Hard.jpg",
                        IMDB = "http://www.imdb.com/title/tt0095016/"
                },
                new Movie()
                {
                    Name = "Die Hard 2",
                    Length = 120,
                    Year = new DateTime(1987, 2, 2),
                    Billede = "~/images/Die_Hard.jpg",
                    IMDB = "http://www.imdb.com/title/tt0099423"
                }
            };

            if (id != 0)
            {
                Movies.Reverse();
                ViewData["Sorting"] = "Length";
            }else
                ViewData["Sorting"] = "Title";

            return View(Movies);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is a text";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "FIXME skriv noget om mig selv.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
