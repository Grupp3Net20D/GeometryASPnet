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
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(10f, 43.3f)]
        public void Triangle_CalculatesArea_ReturnsArea(float side, float expected)
        {
            //Arrange
            var triangle = new Triangle(side);
            //Act
            var actual = triangle.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5f, 15f)]
        public void Triangle_CalculatesPerimeter_ReturnsPerimeter(float side, float expected)
        {
            //Arrange 
            var triangle = new Triangle(side);
            //Act
            var actual = triangle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        [DataRow(-1, 0f)]
        public void Triangle_CalculatesPerimeterWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var triangle = new Triangle(side);
            //Act
            var actual = triangle.GetPerimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        [DataRow(-1f, 0f)]
        public void Triangle_CalculatesAreaWithNegativeValues_ReturnsZero(float side, float expected)
        {
            //Arrange 
            var triangle = new Triangle(side);
            //Act
            var actual = triangle.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }


        
    }
}
