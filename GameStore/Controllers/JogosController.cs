using GameStoreLibrary.Models;
using GameStoreLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class JogosController : Controller
    {
        public ActionResult Index()
        {
            var games = new GameRepository();

            ViewBag.Games = games.GetAllGames();

            return View();
        }

        public ActionResult Details(int id)
        {
            var game = new GameRepository();

            ViewBag.Carne = game.GetGameById(id);

            return View(game.GetGameById(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GameModel game)
        {
            if (ModelState.IsValid)
            {
                var gameObject = new GameRepository();

                gameObject.Create(game);

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var gameObject = new GameRepository();

            var game = gameObject.GetGameById(id);

            if (gameObject != null)
            {
                GameModel gameModel = new GameModel();

                gameModel.Name = game.Name;
                gameModel.Platform = game.Platform;
                gameModel.Price = game.Price;

                return View(gameModel);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Update(GameModel game)
        {
            var gameObject = new GameRepository();

            gameObject.Update(game);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var gameObject = new GameRepository().GetGameById(id);

            if (gameObject != null)
            {
                var gameModel = new GameModel();

                gameModel.Name = gameObject.Name;
                gameModel.Platform = gameObject.Platform;
                gameModel.Price = gameObject.Price;


                return View(gameModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(GameModel game)
        {
            new GameRepository().Delete(game.Id);

            return RedirectToAction("Index");
        }
    }
}