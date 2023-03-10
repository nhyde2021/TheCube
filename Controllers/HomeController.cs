using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheCube.Models;
using NetDeck.Decks;
using NetDeck.Cards;

namespace TheCube.Controllers
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
            StandardDeck deck = new StandardDeck();
            List<StandardPlayingCard> initialDeal = new List<StandardPlayingCard>();

            int xCount = 0;

            for (int i = 0; i < 9; i++)
            {
                StandardPlayingCard card = deck.DrawCard();
                initialDeal.Add(card);
            }
            int remainingCards = deck.CurrentCardCount();


            ViewBag.initialDeal = initialDeal;
            ViewBag.remainingCards = remainingCards;           

           /* while (remainingCards > 0 || xCount < 9)
            {

            }*/

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Rules()
        {
            return View();
        }
        public IActionResult Board()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       


    }

}


