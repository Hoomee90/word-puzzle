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
  }
}