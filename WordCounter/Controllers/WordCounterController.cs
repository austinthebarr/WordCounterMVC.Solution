using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter/Form")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpGet("/WordCounter/Result")]
    public ActionResult Result()
    {
      return View();
    }
    [HttpPost("/WordCounter/Result")]
    public ActionResult NewWordToCount()
    {
      RepeatCounter newWord = new RepeatCounter(Request.Form["newWord"]);
      newWord.SetSentence(Request.Form["newSentence"]);
      return View("result",newWord);
    }
  }
}
