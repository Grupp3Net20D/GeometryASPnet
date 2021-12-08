using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryGrupp3.Controllers;
using GeometriTDD.Geometry;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeometriTDDTests.IntegrationTests
{
    [TestClass()]
    public class ASPTests
    {
        [TestMethod()]
        public void HomeViewTest()
        {
            var mock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> logger = mock.Object;
            HomeController controller = new HomeController(logger);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        /// <summary>
        /// Integration test
        /// </summary>
        [TestMethod()]
        public void CircleViewTest()
        {
            Circle circle = new();
            CircleController controller = new CircleController();
            var result = controller.Index(circle) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
            
            circle.Radie = 10;
            var assert = 62.83000183105469;
            var actual = circle.GetPerimeter();
            Assert.AreEqual(assert, actual);
        }

        /// <summary>
        /// Integration test
        /// </summary>
        [TestMethod()]
        public void TriangleViewTest()
        {
            Triangle triangle = new();
            TriangleController controller = new TriangleController();
            var result = controller.Index(triangle) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
            
            triangle.Side = 10;
            var assert = 30;
            var actual = triangle.GetPerimeter();
            Assert.AreEqual(assert, actual);
        }
        
        /// <summary>
        /// Integration test
        /// </summary>
        [TestMethod()]
        public void RombViewTest()
        {
            Romb romb = new();
            RombController controller = new RombController();
            var result = controller.Index(romb) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
            
            romb.Side = 5;
            romb.Heigth = 10;
            var assert = 50;
            var actual = romb.GetArea();
            Assert.AreEqual(assert, actual);
        }


        /// <summary>
        /// System test
        /// </summary>
        [TestMethod()]
        public void SystemTest()
        {
            var homeMock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> homeLogger = homeMock.Object;
            HomeController homeController = new HomeController(homeLogger);
            var homeResult = homeController.Index() as ViewResult;
            Assert.AreEqual("Index", homeResult.ViewName);

            var contactMock = new Mock<ILogger<ContactFormController>>();
            ILogger<ContactFormController> contactLogger = contactMock.Object;
            ContactFormController contactController = new ContactFormController(contactLogger);
            var contactResult = contactController.Index() as ViewResult; 
            Assert.AreEqual("Index", contactResult.ViewName);

            AboutController aboutController = new();
            var aboutResult = aboutController.Index() as ViewResult;
            Assert.AreEqual("Index", aboutResult.ViewName);

            Circle circle = new();
            Hexagon hexagon = new();
            Pentagon pentagon = new();
            Rectangle rectangle = new();
            Romb romb = new();
            Square square = new();
            Triangle triangle = new();

            CircleController circleController = new();
            HexagonController hexagonController = new();
            PentagonController pentagonController = new();
            RectangleController rectangleController = new();
            RombController rombController = new();
            SquareController squareController = new();
            TriangleController triangleController = new();

            var circleResult = circleController.Index(circle) as ViewResult;
            Assert.AreEqual("Index", circleResult.ViewName);

            var hexagonResult = hexagonController.Index(hexagon) as ViewResult;
            Assert.AreEqual("Index", hexagonResult.ViewName);

            var pentagonResult = pentagonController.Index(pentagon) as ViewResult;
            Assert.AreEqual("Index", pentagonResult.ViewName);

            var rectangleResult = rectangleController.Index(rectangle) as ViewResult;
            Assert.AreEqual("Index", rectangleResult.ViewName);

            var rombResult = rombController.Index(romb) as ViewResult;
            Assert.AreEqual("Index", rombResult.ViewName);

            var squareResult = squareController.Index(square) as ViewResult;
            Assert.AreEqual("Index", squareResult.ViewName);

            var triangleResult = triangleController.Index(triangle) as ViewResult;
            Assert.AreEqual("Index", triangleResult.ViewName);


            circle.Radie = 100f;
            var circlePerimeterAssert = 628.32f;
            var circleAreaAssert = 31415.93f;

            var circlePerimeterActual = circle.GetPerimeter();
            var circleAreaActual = circle.GetArea();

            Assert.AreEqual(circlePerimeterAssert, circlePerimeterActual);
            Assert.AreEqual(circleAreaAssert, circleAreaActual);

            hexagon.Side = 10f;
            var hexagonPerimeterAssert = 60f;
            var hexagonAreaAssert = 259.81f;

            var hexagonPerimeterActual = hexagon.GetPerimeter();
            var hexagonAreaActual = hexagon.GetArea();

            Assert.AreEqual(hexagonPerimeterAssert, hexagonPerimeterActual);
            Assert.AreEqual(hexagonAreaAssert, hexagonAreaActual);

            pentagon.Side = 53f;
            var pentagonPerimeterAssert = 265f;
            var pentagonAreaAssert = 4832.82f;

            var pentagonPerimeterActual = pentagon.GetPerimeter();
            var pentagonAreaActual = pentagon.GetArea();

            Assert.AreEqual(pentagonPerimeterAssert, pentagonPerimeterActual);
            Assert.AreEqual(pentagonAreaAssert, pentagonAreaActual);

            rectangle.Bas = 10.15213f;
            rectangle.Height = 19.59329f;
            var rectanglePerimeterAssert = 59.49f;
            var rectangleAreaAssert = 198.91f;

            var rectanglePerimeterActual = rectangle.GetPerimeter();
            var rectangleAreaActual = rectangle.GetArea();

            Assert.AreEqual(rectanglePerimeterAssert, rectanglePerimeterActual);
            Assert.AreEqual(rectangleAreaAssert, rectangleAreaActual);

            romb.Side = 13f;
            romb.Heigth = 0.32f;
            var rombPerimeterAssert = 52f;
            var rombAreaAssert = 4.16f;

            var rombPerimeterActual = romb.GetPerimeter();
            var rombAreaActual = romb.GetArea();

            Assert.AreEqual(rombPerimeterAssert, rombPerimeterActual);
            Assert.AreEqual(rombAreaAssert, rombAreaActual);

            square.Side = 5f;
            var squarePerimeterAssert = 20f;
            var squareAreaAssert = 25f;

            var squarePerimeterActual = square.GetPerimeter();
            var squareAreaActual = square.GetArea();
            
            Assert.AreEqual(squarePerimeterAssert, squarePerimeterActual);
            Assert.AreEqual(squareAreaAssert, squareAreaActual);

            triangle.Side = 10f;
            var trianglePerimeterAssert = 30f;
            var triangleAreaAssert = 43.3f;

            var trianglePerimeterActual = triangle.GetPerimeter();
            var triangleAreaActual = triangle.GetArea();

            Assert.AreEqual(trianglePerimeterAssert, trianglePerimeterActual);
            Assert.AreEqual(triangleAreaAssert, triangleAreaActual);
        }
    }
}