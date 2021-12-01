using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriTDD;
using GeometriTDD.Geometry;

namespace GeometriTDDTests.GeometryTests
{
    [TestClass()]
    public class PentagonTests
    {
        [TestMethod()]
        [DataRow(10f, 172.05f)]
        public void Pentagon_CalculatesArea_ReturnsArea(float side, float expected)
        {
            //Arrange
            var pentagon = new Pentagon(side);
            //Act
            var actual = pentagon.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(10f, 50f)]
        public void Pentagon_CalculatesPerimeter_ReturnsPerimeter(float side, float expected)
        {
            //Arrange
            var pentagon = new Pentagon(side);
            //Act
            var actual = pentagon.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        [DataRow(-1, 0f)]
        public void Pentagon_CalculatesPerimeterWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var pentagon = new Pentagon(side);
            //Act
            var actual = pentagon.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        [DataRow(-1, 0f)]
        public void Pentagon_CalculatesAreaWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var pentagon = new Pentagon(side);
            //Act
            var actual = pentagon.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
