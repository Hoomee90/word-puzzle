using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Tests
{
	[TestClass]
	public class EasyGameTests
	{
		[TestMethod]
		public void EasyGameConstructor_CreateInstanceOfEasyGame_EasyGame()
		{
			EasyGame newEasyGame = new("witch");
			Assert.AreEqual(typeof(EasyGame), newEasyGame.GetType());
		}
		
		[TestMethod]
		public void GetAnswer_ReturnsAnswer_String()
		{
			string word = "witch";
			EasyGame newEasyGame = new(word);
			string result = newEasyGame.GetAnswer();
			Assert.AreEqual(word, result);
		}
		
		[TestMethod]
		public void GetGuessesLeft_ReturnsGuessesLeft_Int()
		{
			int guesses = 6;
			EasyGame newEasyGame = new("witch");
			int result = newEasyGame.GuessesLeft;
			Assert.AreEqual(guesses, result);
		}
		
		[TestMethod]
		public void SetGuessesLeft_SetsValueOfGuessesLeft_Void()
		{
			EasyGame newEasyGame = new("witch");
			int newGuesses = 4;
			newEasyGame.GuessesLeft = newGuesses;
			Assert.AreEqual(newGuesses, newEasyGame.GuessesLeft);
		}
		
		[TestMethod]
		public void GetCorrectLetters_ReturnsCorrectLetters_Void()
		{
			string word = "witch";
			EasyGame newEasyGame = new(word);
			char[] correctLetters = newEasyGame.CorrectLetters;
			CollectionAssert.AreEqual(new char[word.Length], correctLetters);
		}
		
		[TestMethod]
		public void Guess_ReturnsFalseOnFailedGuess_Bool()
		{
			EasyGame newEasyGame = new("witch");
			bool result = newEasyGame.Guess('x');
			Assert.AreEqual(false, result);
		}
		
		[TestMethod]
		public void Guess_ReturnsTrueOnSuccessfulGuess_Bool()
		{
			EasyGame newEasyGame = new("witch");
			bool result = newEasyGame.Guess('w');
			Assert.AreEqual(true, result);
		}
		
		[TestMethod]
		public void Guess_UpdatesCorrectLetters_Void()
		{
			char[] expected = new char[5];
			expected[0] = 'w';
			expected[3] = 'c';
			EasyGame newEasyGame = new("witch");
			newEasyGame.Guess('w');
			newEasyGame.Guess('c');
			char[] result = newEasyGame.CorrectLetters;
			CollectionAssert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void GetGuessedLetters_ReturnsGuessedLetters_Int()
		{
			List<char> expected = new(new[]{'w', 'c'});
			EasyGame newEasyGame = new("witch");
			newEasyGame.Guess('w');
			newEasyGame.Guess('c');
			CollectionAssert.AreEqual(expected, newEasyGame.GuessedLetters);
		}
		
		[TestMethod]
		public void Guess_UpdatesGuessesLeft_Void()
		{
			int expected = 4;
			EasyGame newEasyGame = new("witch");
			newEasyGame.Guess('m');
			newEasyGame.Guess('a');
			newEasyGame.Guess('i');
			Assert.AreEqual(expected, newEasyGame.GuessesLeft);
		}
	}
}