using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void HomeControllerShowingCorrectView_True()
    {
      //arrange
      HomeController newController = new HomeController();

      //act
      ActionResult indexview = newController.Index();

      //Assert
      Assert.IsInstanceOfType(indexview, typeof(ViewResult));
    }
  }
}
