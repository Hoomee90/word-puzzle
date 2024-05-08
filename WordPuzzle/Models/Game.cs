using System;
using System.Linq;

namespace WordPuzzle.Models
{
	public class Game
	{
		public string Answer { get; set; }
		public int GuessesLeft { get; set; } = 5;
		public char[] CorrectLetters 
		{ 
			get { return _correctLetters; }
		}
		private char[] _correctLetters;
		public Game(string word)
		{
			Answer = word;
			_correctLetters = new char[word.Length];
		}
		
		public bool Guess(char letter)
		{
			// TODO: make guesses update CorrectLetters
			if (Answer.Contains(letter))
			{
				char[] answerChars = Answer.ToCharArray();
				for (int i = 0; i < answerChars.Length; i++)
				{
					if (answerChars[i] == letter)
					{
						CorrectLetters[i] = answerChars[i];
					}
				}
				
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}