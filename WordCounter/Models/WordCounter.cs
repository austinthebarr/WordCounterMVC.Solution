using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _userWord;
    List<string> wordList = new List<string> {};

    public RepeatCounter(string userWord)
    {
      _userWord = userWord;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }
  }
}
