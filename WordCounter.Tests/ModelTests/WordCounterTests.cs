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
    public void MultipleWords_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("the buddy");

      //act
      string split = newWord.SeperateWords();


      //Assert
      Assert.AreEqual(split, "2");
    }

    [TestMethod]
    public void SixWords_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("the dude has all the answers");

      //act
      string split = newWord.SeperateWords();


      //Assert
      Assert.AreEqual(split, "6");
    }

    [TestMethod]
    public void NineWords_True()
    {
      //assign
      RepeatCounter newWord = new RepeatCounter("You think the pet rock was a good idea?");
      //act
      string split = newWord.SeperateWords();


      //Assert
      Assert.AreEqual(split, "9");
    }

    // [TestMethod]
    // public void DictionaryWorks_true()
    // {
    //   //assign
    //   RepeatCounter newWord = new RepeatCounter("bob");
    //   Dictionary<string, int> repeatedWordCount = new Dictionary<string,int>{};
    //
    //   //act
    //  newWord.CreateDictionary();
    //  Console.WriteLine(repeatedWordCount.ContainsKey("1"));
    //  Console.WriteLine(repeatedWordCount);
    //
    //   //Assert
    //   Assert.AreEqual(repeatedWordCount["bob"] , 1);
    //
    // }
  }
}
