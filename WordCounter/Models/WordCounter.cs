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

    Dictionary<string, int> RepeatedWordCount = new Dictionary<string,int>{};

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

    // public void CreateDictionary()
    // {
    //   Dictionary<string, int> RepeatedWordCount = new Dictionary<string,int>{};
    //   string words = this.GetWord();
    //   string[] splitUpWords = words.ToLower().Split(' ');
    //   for (int i = 0; i < splitUpWords.Length; i++)
    //   {
    //     if(RepeatedWordCount.ContainsKey(splitUpWords[i]))
    //     {
    //       int value = RepeatedWordCount[splitUpWords[i]];
    //       RepeatedWordCount[splitUpWords[i]] = value +1;
    //     }
    //     else
    //     {
    //       RepeatedWordCount.Add(splitUpWords[i], 1);
    //     }
    //   }
    // }
  }
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Give me a word for me to count!")
    }
  }
}
