using FilmListApp.Constructor;
using FilmListApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmListApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<FilmsModel> lstFilms = new List<FilmsModel>();
            FilmsConst Film = new FilmsConst("The Incredible hulk", "2:40:30", "Bruce Banner, a scientist on the run from the U.S. Government, must find a cure for the monster he turns into whenever he loses his temper.");
            lstFilms.Add(Film.FilmsModel);

            FilmsConst Film1 = new FilmsConst("Avengers: Infinity War", "2:29:40", "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.");
            lstFilms.Add(Film1.FilmsModel);

            FilmsConst Film2 = new FilmsConst("Thor: Ragnarok", "2:10:40", "Imprisoned on the planet Sakaar, Thor must race against time to return to Asgard and stop Ragnarök, the destruction of his world, at the hands of the powerful and ruthless villain Hela.");
            lstFilms.Add(Film2.FilmsModel);

            return View(lstFilms as IEnumerable<FilmsModel>);
        }

    }
}
