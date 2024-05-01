using System;
using System.Linq;

namespace WordPuzzle.Models
{
	public class Game
	{
		public string Answer { get; set; }
		public int GuessesLeft { get; set; } = 5;
		public char[] GuessedLetters 
		{ 
			get { return _guessedLetters; }
		}
		private char[] _guessedLetters;
		public Game(string word)
		{
			Answer = word;
			_guessedLetters = new char[word.Length];
		}
		
		public bool Guess(char letter)
		{
			if (Answer.Contains(letter))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}