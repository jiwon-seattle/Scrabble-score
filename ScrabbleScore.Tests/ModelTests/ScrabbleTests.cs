using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Words.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {

    [TestMethod]
    public void Scrabbles_CheckingScrabbleOne_GetScrabbleOne()
    {
      // Arrang
      string a ="a";
      Scrabble newScrabble = new Scrabble(a);
      // Act
      string result = newScrabble.CheckingScrabbleOne();
      // Assert
      Assert.AreEqual(result, "1");
    }

    
  }
  
}