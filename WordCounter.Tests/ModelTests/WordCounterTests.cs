using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Test
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetwordBySetttingWord_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("the");

      //act
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(result,"the");
    }
    [TestMethod]
    public void GetwordBySetttingWord_False()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("the");

      //act
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(result,"the");
    }
    [TestMethod]
    public void MultipleWords_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("the buddy");

      //act
      string split = newWord.SeperateWords();


      //Assert
      Assert.AreEqual(split, "2");
    }
  }
}
