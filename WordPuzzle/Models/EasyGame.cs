using System;

namespace WordPuzzle.Models
{
	public class EasyGame : Game
	{
		
		public EasyGame(string word)
		{
			_answer = word;
			CorrectLetters = new char[word.Length];
			GuessesLeft = 6;
		}
		
		public override bool Guess(char letter)
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
	}
}