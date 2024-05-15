using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPuzzle.Models;

namespace WordPuzzle.Tests
{
	[TestClass]
	public class ImpossibleGameTests
	{
		[TestMethod]
		public void RevealAnswer_ReturnsWordOptionNotGuessed_CharArray()
		{
			string expected = "banana";
			ImpossibleGame newGame = new();
			newGame.Guess('e');
			newGame.Guess('y');
			newGame.Guess('i');
			newGame.Guess('o');
			newGame.Guess('u');
			CollectionAssert.AreEqual(expected.ToCharArray(), newGame.GetAnswer());
		}
		
		[TestMethod]
		public void CurrentGame_UpdatesGamePropertyToCurrentGame_ImpossibleGame()
		{
			ImpossibleGame newGame = new();
			Assert.AreEqual(newGame, Game.CurrentGame);
		}
	}
}