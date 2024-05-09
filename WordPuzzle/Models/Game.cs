using System.Collections.Generic;

namespace WordPuzzle.Models
{
	public abstract class Game
	{
		internal string _answer;
		public int GuessesLeft { get; set; }
		public char[] CorrectLetters { get; set; }
		public List<char> GuessedLetters { get; } = new();
		
		public abstract bool Guess(char letter);
		
		public virtual string GetAnswer()
		{
			return _answer;
		}
	}
}