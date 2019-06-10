using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTicTacToe.Models;

namespace MvcTicTacToe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StartNewGame(string selectedPlayer, bool startingMove)
        {
            TempData["selectedPlayer"] = selectedPlayer;
            TempData["startingMove"] = startingMove;
            GameController.board = null;
            return RedirectToAction("Index", "Game");
        }
    }
}