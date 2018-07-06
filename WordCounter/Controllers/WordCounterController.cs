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
  }
}
