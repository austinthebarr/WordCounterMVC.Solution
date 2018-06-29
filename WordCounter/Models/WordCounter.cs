using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _userWord;

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

    public string SeperateWords()
    {
      string words = this.GetWord();
      string[] seperate = words.ToLower().Split(' ');
      int count = 0;
      foreach (string word in seperate)
      {
        count +=1;
      }
      return count.ToString();
    }
  }
}
