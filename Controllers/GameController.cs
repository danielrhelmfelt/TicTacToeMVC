using System;
using Microsoft.AspNetCore.Mvc;
using MvcTicTacToe.Models;

namespace MvcTicTacToe.Controllers
{
    public class GameController : Controller
    {
        public static Board board;
        public ActionResult Index()
        {
            if (board == null)
            {
                string selectedPlayer = (string)TempData["selectedPlayer"];
                bool startingMove = (bool)TempData["startingMove"];
                board = new Board();
                board.PlayerSelected = selectedPlayer;
                board.PlayerStarts = startingMove;
                // si inicia la IA, se realiza el primer movimiento
                if (startingMove == false)
                {
                    board.doIaTurnMove();
                }
            }
            ViewData["Board"] = board;
            return View();
        }

        public ActionResult CellOnClick(int row, int col)
        {
            board.cellSelectedAction(row, col);
            ViewData["Board"] = board;
            return View("Index");
        }
    }
}