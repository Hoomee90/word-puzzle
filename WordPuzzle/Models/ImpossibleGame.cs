using System;

namespace WordPuzzle.Models
{
	public class ImpossibleGame : Game
	{
		public string[] WordOptions { get; } = { "banana", "excess", "giggit", "voodoo", "pullup", "myrrhy" };
		
		public ImpossibleGame()
		{
			GuessesLeft = 5;
			CorrectLetters = new char[6];
			Array.Fill(CorrectLetters, '_');
		}
		
		public override bool Guess(char letter)
		{
			GuessedLetters.Add(letter);
			GuessesLeft--;
			return false;
		}
		
		public override char[] GetAnswer()
		{
			return Array.Find(WordOptions, el => !GuessedLetters.Exists(ch => el.Contains(ch))).ToCharArray();
		}
	}
}