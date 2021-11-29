using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriTDD.Geometry;
using System;


namespace GeometriTDDTests.GeometryTests
{
    [TestClass()]
    public class HexagonTest
    {
        [TestMethod]
        [DataRow(1f,2.6f)]
        public void Hexagon_CalculatesArea_ReturnsArea(float side, float expected)
        {
            var hexagon = new Hexagon(side);
            var actual = hexagon.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(6f,36f)]
        public void Hexagon_CalculatesPerimeters_ReturnsPerimeters(float side, float expected)
        {
            var hexagon = new Hexagon(side);
            var actual = hexagon.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]

        public void Hexagon_CalculatesPerimeterWithNegativeValues_ReturnsZero(float side, float expected)
        {
            var hexagon = new Hexagon(side);
            var actual = hexagon.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(null, 0f)]
        [DataRow(0f, 0f)]
        public void Hexagon_CalculatesAreaWithNegativeValues_ReturnsZero(float side, float expected)
        {
            var hexagon = new Hexagon(side);
            var actual = hexagon.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
    }

}

