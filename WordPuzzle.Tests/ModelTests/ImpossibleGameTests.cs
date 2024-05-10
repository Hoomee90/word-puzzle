using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Tests
{
	[TestClass]
	public class ImpossibleGameTests
	{
		[TestMethod]
		public void RevealAnswer_ReturnsWordOptionNotGuessed_String()
		{
			string expected = "banana";
			ImpossibleGame newGame = new();
			newGame.Guess('e');
			newGame.Guess('y');
			newGame.Guess('i');
			newGame.Guess('o');
			newGame.Guess('u');
			Assert.AreEqual(expected, newGame.GetAnswer());
		}
		
		[TestMethod]
		public void CurrentGame_UpdatesGamePropertyToCurrentGame_ImpossibleGame()
		{
			ImpossibleGame newGame = new();
			Assert.AreEqual(newGame, Game.currentGame);
		}
	}
}