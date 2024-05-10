using Microsoft.AspNetCore.Mvc;
using WordPuzzle.Models;

namespace WordPuzzle.Controllers
{
	public class GameController : Controller
	{
		
		[HttpGet("/game")]
		public ActionResult Index()
		{
			return View();
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
				EasyGame _ = new("test");
			}
			return RedirectToAction("Index");
		}
	}
}