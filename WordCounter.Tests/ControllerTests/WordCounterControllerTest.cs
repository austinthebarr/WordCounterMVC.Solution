using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void WordCounterControllerShowingCorrectView_True()
    {
      //arrange
      WordCounterController newController = new WordCounterController();

      //act
      ActionResult indexview = newController.Form();

      //Assert
      Assert.IsInstanceOfType(indexview, typeof(ViewResult));
    }
  }
}
