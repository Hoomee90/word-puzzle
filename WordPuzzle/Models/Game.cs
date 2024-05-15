using System.Collections.Generic;

namespace WordPuzzle.Models
{
	public abstract class Game
	{
		public static Game CurrentGame { get; set; }
		internal char[] _answer;
		public int GuessesLeft { get; set; }
		public char[] CorrectLetters { get; set; }
		public List<char> GuessedLetters { get; } = new();
		
		public Game()
		{
			CurrentGame = this;
		}
		public abstract bool Guess(char letter);
		
		public virtual char[] GetAnswer()
		{
			return _answer;
		}
	}
}