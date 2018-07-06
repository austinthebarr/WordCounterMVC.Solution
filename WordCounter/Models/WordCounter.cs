using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _userWord;
    private int _wordOccurences;
    private string _userSentence;

    public RepeatCounter(string userWord)
    {
      _userWord = userWord;
      _wordOccurences = 0;
      _userSentence = "";
    }

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

    public string GetSentence()
    {
      return _userSentence;
    }

    public void SetSentence(string newSentence)
    {
      _userSentence = newSentence;
    }

    public string SearchWord()
    {
      string words = this.GetWord().ToLower();
      string [] searchSentence = this.GetSentence().ToLower().Split(' ');
      int count = 0;
      foreach (string word in searchSentence)
      {
        if (words == word)
        {
          count +=1;
        }
      }
      return count.ToString();
    }
  }
}  
//   class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("Give me a word to search.");
//       string inputtedWord = Console.ReadLine();
//
//       Console.WriteLine("Give me a sentence to search for the word.");
//       string inputtedSentence = Console.ReadLine();
//
//       RepeatCounter newWord = new RepeatCounter(inputtedWord);
//       newWord.SetSentence(inputtedSentence);
//
//       Console.WriteLine(newWord.GetWord() + " occured " + newWord.SearchWord() + " times.");
//     }
//   }
// }
