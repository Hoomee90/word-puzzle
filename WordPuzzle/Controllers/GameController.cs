using Microsoft.AspNetCore.Mvc;

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
		public ActionResult Create(string word)
		{
			return RedirectToAction("Index");
		}
	}
}