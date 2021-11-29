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
    public class RectangleTests
    {
        [TestMethod]
        [DataRow(2f, 4f, 8f)]
        public void Rectangle_CalculatesArea_ReturnsArea(float bas, float heigth, float expected)
        {
            //Arrange 
            var rectangle = new Rectangle(bas, heigth);
            //Act
            var actual = rectangle.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, 1f, 4f)]
        public void Rectangle_CalculatesPerimeter_ReturnsArea(float heigth, float side, float expected)
        {
            //Arrange 
            var rectangle = new Rectangle(heigth, side);
            //Act
            var actual = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, null, 0f)]
        [DataRow(0f, 2f, 0f)]
        public void Rectangle_CalculatesPerimeterWithNegativeValues_ReturnsZero(float heigth, float side, float expected)
        {
            //Arrange 
            var rectangle = new Rectangle(heigth, side);
            //Act
            var actual = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, null, 0f)]
        [DataRow(0f, 2f, 0f)]
        public void Rectangle_CalculatesAreaWithNegativeValues_ReturnsZero(float heigth, float side, float expected)
        {
            //Arrange 
            var rectangle = new Rectangle(heigth, side);
            //Act
            var actual = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
