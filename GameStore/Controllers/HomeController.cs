using GameStoreLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var game = new GameRepository();

            ViewBag.GoW = game.GetGameById(1);
            ViewBag.EldenRing = game.GetGameById(2);
            ViewBag.CoDMW2 = game.GetGameById(4);
            ViewBag.Fifa = game.GetGameById(5);
            ViewBag.SpiderMan = game.GetGameById(6);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}