using System.Collections.Generic;

namespace WordPuzzle.Models
{
	public class Game
	{
		private string _answer;
		public int GuessesLeft { get; set; } = 6;
		public char[] CorrectLetters { get; }
		public List<char> GuessedLetters { get; } = new();
		
		public Game(string word)
		{
			_answer = word;
			CorrectLetters = new char[word.Length];
		}
		
		public virtual bool Guess(char letter)
		{
			GuessedLetters.Add(letter);
			if (_answer.Contains(letter))
			{
				char[] answerChars = _answer.ToCharArray();
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
				GuessesLeft--;
				return false;
			}
		}
		
		public virtual string GetAnswer()
		{
			return _answer;
		}
	}
}