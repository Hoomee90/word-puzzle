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
			Game.CurrentGame.Guess('u');
			Game.CurrentGame.Guess('z');
			Game.CurrentGame.Guess('a');
			return RedirectToAction("Index");
		}
	}
}