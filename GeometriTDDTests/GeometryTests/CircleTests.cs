using GeometriTDD.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriTDDTests.GeometryTests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod]
        [DataRow(1f, 3.14f)]
        public void Circle_CalculatesArea_ReturnsArea(float radie, float expected)
        {
            //Arrange 
            var circle = new Circle(radie);
            //Act
            var actual = circle.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(2f, 12.57f)]
        public void Circle_CalculatesPerimeter_ReturnsArea(float radie, float expected)
        {
            //Arrange 
            var circle = new Circle(radie);
            //Act
            var actual = circle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        public void Circle_CalculatesPerimeterWithNegativeValues_ReturnsZero(float radie, float expected)
        {
            //Arrange 
            var circle = new Circle(radie);
            //Act
            var actual = circle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        public void Circle_CalculatesAreaWithNegativeValues_ReturnsZero(float radie, float expected)
        {
            //Arrange 
            var circle = new Circle(radie);
            //Act
            var actual = circle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
