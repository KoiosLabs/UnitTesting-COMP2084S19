using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingTest.Models;
using UnitTestingTest.Controllers;
namespace UnitTestingTest.Tests.Controllers
{
    [TestClass]
    public class MathControllerTests
    {
        [TestMethod]
        public void ControllerUsesMathService()
        {
            //Arrange
            var service = new SpyMathService { Add_Result = 42 }; // The answer to life, the universe, and everything.
            var controller = new MathController(service); //Now we can pass our fake in!
            int left = 4;
            int right = 12;

            //Act
            var result = controller.Add(left, right);

            //Assert
            Assert.AreEqual(service.Add_Result, result.ViewBag.TotalCount);
            Assert.AreEqual(service.Add_Left, left);
            Assert.AreEqual(service.Add_Right, right);
        }
    }
}
