using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingTest.Models;
namespace UnitTestingTest.Tests.Controllers
{
    [TestClass]
    public class MathServiceTests
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            MathService s = new MathService();
            int left, right, ExpectedResult;
            left = 5;
            right = 5;
            ExpectedResult = left + right;

            //Act
            int result = s.Add(left,right);

            //Assert
            Assert.AreEqual(result, ExpectedResult);
        }
    }
}
