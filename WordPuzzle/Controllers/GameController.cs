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
			return RedirectToAction("Index");
		}
	
		[HttpGet("/game/guess")]
		public ActionResult Edit()
		{
			Game game = Game.CurrentGame;
			return View(game);
		}
		
		[HttpPost("/game/guess")]
		public ActionResult Update(string guess)
		{
			
			Game.CurrentGame.Guess(char.Parse(guess));
			if (Game.CurrentGame.GuessesLeft < 1)
			{
				return RedirectToAction("Lose");
			}
			else if (Game.CurrentGame.CorrectLetters.ToString() == Game.CurrentGame.GetAnswer())
			{
				return RedirectToAction("Win");
			}
			return RedirectToAction("Index");
		}
		
		[HttpGet("/game/victory")]
		public ActionResult Win()
		{
			Game game = Game.CurrentGame;
			return View(game);
		}
		
		[HttpGet("/game/defeat")]
		public ActionResult Lose()
		{
			Game game = Game.CurrentGame;
			return View(game);
		}
	}
}