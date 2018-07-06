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
    // [HttpPost("/WordCounter/WordCount")]
    // public ActionResult WordCount()
    // {
    //
    // }
  }
}
