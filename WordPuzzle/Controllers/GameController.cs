using Microsoft.AspNetCore.Mvc;
using WordPuzzle.Models;

namespace WordPuzzle.Controllers
{
	public class GameController : Controller
	{
		
		[HttpGet("/game")]
		public ActionResult Index()
		{
			Game game = Game.CurrentGame;
			return View(game);
		}
		
		[HttpGet("/game/new")]
		public ActionResult New()
		{
			return View();
		}
		
		[HttpPost("/game")]
		public ActionResult Create(string difficulty)
		{
			if (difficulty == "hard")
			{
				ImpossibleGame _ = new();
			}
			else
			{
				EasyGame _ = new("curses");
			}
			// Game.CurrentGame.Guess('u');
			// Game.CurrentGame.Guess('z');
			// Game.CurrentGame.Guess('a');
			// Game.CurrentGame.Guess('s');
			// Game.CurrentGame.Guess('x');
			// Game.CurrentGame.Guess('y');
			// Game.CurrentGame.Guess('r');
			// Game.CurrentGame.Guess('b');
			// Game.CurrentGame.Guess('t');
			return RedirectToAction("Index");
		}
		
		[HttpGet("/game/guess")]
		public ActionResult Edit()
		{
			return View();
		}
	}
}