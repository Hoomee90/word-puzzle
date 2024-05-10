using System;

namespace WordPuzzle.Models
{
	public class ImpossibleGame : Game
	{
		public string[] WordOptions { get; } = { "banana", "excess", "giggit", "voodoo", "pullup", "myrrhy" };
		
		public ImpossibleGame()
		{
			GuessesLeft = 5;
		}
		
		public override bool Guess(char letter)
		{
			GuessedLetters.Add(letter);
			GuessesLeft--;
			return false;
		}
		
		public override string GetAnswer()
		{
			return Array.Find(WordOptions, el => !GuessedLetters.Exists(ch => el.Contains(ch)));
		}
	}
}