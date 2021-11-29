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
    public class SquareTests
    {
        [TestMethod]
        [DataRow(4f, 16f)]
        public void Square_CalculatesArea_ReturnsArea(float side, float expected)
        {
            //Arrange 
            var square = new Square(side);
            //Act
            var actual = square.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow( 1f, 4f)]
        public void Square_CalculatesPerimeter_ReturnsArea(float side, float expected)
        {
            //Arrange 
            var square = new Square(side);
            //Act
            var actual = square.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        public void Square_CalculatesPerimeterWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var square = new Square(side);
            //Act
            var actual = square.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        public void Square_CalculatesAreaWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var square = new Square(side);
            //Act
            var actual = square.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

