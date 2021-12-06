using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using GeometryGrupp3.Controllers;
using System.Threading;
using Moq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeometriTDDTests.IntegrationTests
{
    [TestClass()]
    public class ASPTests
    {
        //private ILogger<HomeController> logger;
        [TestMethod()]
        public void HomeViewTest()
        {
            var mock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> logger = mock.Object;
            HomeController controller = new HomeController(logger);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod()]
        public void CircleViewTest()
        {
            CircleController controller = new CircleController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
            

            GeometriTDD.Geometry.Circle circle = new();
            circle.Radie = 10;
            var assert = 62.83000183105469;
            var actual = circle.GetPerimeter();
            Assert.AreEqual(assert, actual);
        }
        
    }
}