using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Tests
{
	[TestClass]
	public class GameTests
	{
		[TestMethod]
		public void GameConstructor_CreateInstanceOfGame_Game()
		{
			Game newGame = new("witch");
			Assert.AreEqual(typeof(Game), newGame.GetType());
		}
		
		[TestMethod]
		public void GetAnswer_ReturnsAnswer_String()
		{
			string word = "witch";
			Game newGame = new(word);
			string result = newGame.Answer;
			Assert.AreEqual(word, result);
		}
		
		[TestMethod]
		public void SetAnswer_SetsValueOfAnswer_Void()
		{
			Game newGame = new("witch");
			string newWord = "hope";
			newGame.Answer = newWord;
			Assert.AreEqual(newWord, newGame.Answer);
		}
		
		[TestMethod]
		public void GetGuessesLeft_ReturnsGuessesLeft_Int()
		{
			int guesses = 5;
			Game newGame = new("witch");
			int result = newGame.GuessesLeft;
			Assert.AreEqual(guesses, result);
		}
		
		[TestMethod]
		public void SetGuessesLeft_SetsValueOfGuessesLeft_Void()
		{
			Game newGame = new("witch");
			int newGuesses = 4;
			newGame.GuessesLeft = newGuesses;
			Assert.AreEqual(newGuesses, newGame.GuessesLeft);
		}
		
		[TestMethod]
		public void GetGuessedLetters_ReturnsGuessedLetters_Void()
		{
			string word = "witch";
			Game newGame = new(word);
			char[] guessedLetters = newGame.GuessedLetters;
			CollectionAssert.AreEqual(guessedLetters, new char[word.Length]);
		}
		
		[TestMethod]
		public void Guess_ReturnsFalseOnFailedGuess_Bool()
		{
			Game newGame = new("witch");
			bool result = newGame.Guess('x');
			Assert.AreEqual(false, result);
		}
		
		[TestMethod]
		public void Guess_ReturnsTrueOnSuccessfulGuess_Bool()
		{
			Game newGame = new("witch");
			bool result = newGame.Guess('w');
			Assert.AreEqual(true, result);
		}
	}
}