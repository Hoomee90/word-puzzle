using System.Collections.Generic;

namespace WordPuzzle.Models
{
	public class Game
	{
		public string Answer { get; set; }
		public int GuessesLeft { get; set; } = 5;
		public char[] CorrectLetters { get; }
		public List<char> GuessedLetters { get; } = new();
		
		public Game(string word)
		{
			Answer = word;
			CorrectLetters = new char[word.Length];
		}
		
		public bool Guess(char letter)
		{
			GuessedLetters.Add(letter);
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