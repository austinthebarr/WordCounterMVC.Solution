using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _userWord;
    private int _wordOccurences;

    public RepeatCounter(string userWord)
    {
      _userWord = userWord;
      _wordOccurences = 0;
    }

    Dictionary<string, int> repeatedWordCount = new Dictionary<string,int>{};

    public string GetWord()
    {
      return _userWord;
    }

    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }

    public void setOccurence(int wordOccurnces)
    {
    _wordOccurences = wordOccurnces;
    }

    public int getOccurnces()
    {
      return _wordOccurences;
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
    //
    // public void CreateDictionary()
    // {
    //   Dictionary<string, int> repeatedWordCount = new Dictionary<string,int>{};
    //   string words = this.GetWord();
    //   string[] splitUpWords = words.ToLower().Split(' ');
    //   for (int i = 0; i < splitUpWords.Length; i++)
    //   {
    //     if(repeatedWordCount.ContainsKey(splitUpWords[i]))
    //     {
    //       int value = repeatedWordCount[splitUpWords[i]];
    //       repeatedWordCount[splitUpWords[i]] = value +1;
    //     }
    //     else
    //     {
    //       repeatedWordCount.Add(splitUpWords[i], 1);
    //     }
    //   }
    // }
  }
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Give me a sentance!");
      string userInputSentence = Console.ReadLine();
      string[] userSentence = userInputSentence.ToLower().Split(' ');
      Console.WriteLine("Give me a word for me to count in your sentance!");
       string inputtedString = Console.ReadLine().ToLower();
       RepeatCounter newWord = new RepeatCounter(inputtedString);
       int occurence = 0;
       foreach (string word in userSentence)
       {
         if (inputtedString == word )
         {
           occurence += 1;
         }
         newWord.setOccurence(occurence);
       }
       Console.WriteLine(newWord.GetWord() + " Occures " + newWord.getOccurnces());
    }
  }
}
