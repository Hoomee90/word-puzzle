namespace WordPuzzle.Models
{
	public class Game
	{
		public string Answer { get; set; }
		
		public Game(string word)
		{
			Answer = word;
		}
	}
}