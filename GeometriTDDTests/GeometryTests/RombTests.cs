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
    public class RombTests
    {
        [TestMethod]
        [DataRow(1f, 1f, 1f)]
        [DataRow(2f, 2f, 4f)]
        public void Rhombus_CalculatesArea_ReturnsArea(float heigth, float side, float expected)
        {
            //Arrange 
            var rhombus = new Romb(heigth, side);
            //Act
            var actual = rhombus.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, 1f, 4f)]
        [DataRow(2f, 2f, 8f)]
        public void Rhombus_CalculatesPerimeter_ReturnsArea(float heigth, float side, float expected)
        {
            //Arrange 
            var rhombus = new Romb(heigth, side);
            //Act
            var actual = rhombus.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, null, 0f)]
        [DataRow(0f, 2f, 0f)]
        public void Rhombus_CalculatesPerimeterWithNegativeValues_ReturnsZero(float heigth, float side, float expected)
        {
            //Arrange 
            var rhombus = new Romb(heigth, side);
            //Act
            var actual = rhombus.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1f, null, 0f)]
        [DataRow(0f, 2f, 0f)]
        public void Rhombus_CalculatesAreaWithNegativeValues_ReturnsZero(float heigth, float side, float expected)
        {
            //Arrange 
            var rhombus = new Romb(heigth, side);
            //Act
            var actual = rhombus.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
