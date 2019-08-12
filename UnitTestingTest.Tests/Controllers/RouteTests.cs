using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web;
using System.Web.Routing;
using UnitTestingTest;
using System.Web.Mvc;

namespace UnitTestingTest.Tests.Controllers
{
    [TestClass]
    public class RouteTests
    {
        [TestMethod]
        public void RouteForEmbeddedResource()
        {
            //Arrange
            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns("~/handler.axd");

            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);


            //Act
            RouteData routeData = routes.GetRouteData(mockContext.Object);

            //Assert
            Assert.IsNotNull(routeData);
            Assert.IsInstanceOfType(routeData.RouteHandler, typeof(StopRoutingHandler));

        }
        [TestMethod]
        public void RouteToHomePage()
        {

            //Arrange
            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns("~/");
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            //Act
            RouteData routeData = routes.GetRouteData(mockContext.Object);

            //Assert
            Assert.IsNotNull(routeData);
            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
            Assert.AreEqual(UrlParameter.Optional, routeData.Values["id"]);
        }
    }
}
