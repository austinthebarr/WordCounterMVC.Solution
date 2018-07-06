using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

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
    public void SeperateWordsActuallyWorks_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("buddy");
      newWord.SetSentence("Hello buddy");

      //act
      string result = newWord.GetWord();
      string number = newWord.SearchWord();

      //Assert
      Assert.AreEqual(number, "1");
    }

    [TestMethod]
    public void SeperateWordsFindsmultipleWords_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("dude");
      newWord.SetSentence("The dude walks like a dude");

      //act
      string result = newWord.GetWord();
      string number = newWord.SearchWord();
      //Assert
      Assert.AreEqual(number, "2");
    }

    [TestMethod]
    public void SeperateWordsFindsmultipleWordsWithCapitals_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("LiKE");
      newWord.SetSentence("the girl was liKE , omg like thats crazy, LIKe crazy.");

      //act
      string result = newWord.GetWord();
      string number = newWord.SearchWord();

      //failed since get this word was not lower
      //Assert
      Assert.AreEqual(number, "3");
    }

    [TestMethod]
    public void SeperateWordsFindsmultipleWordsWithCapitals_False()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("LiKE");
      newWord.SetSentence("the girl was liKE , omg like thats crazy, LIKe crazy. Like omg");

      //act
      string result = newWord.GetWord();
      string number = newWord.SearchWord();

      //Assert
      Assert.AreEqual(number, "4");
    }
  }
}
