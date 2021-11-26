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
        public void GetAreaOnePentagon()
        {
            var calc = new GeometricCalculator();
            float expected = 172.05f;
            var pentagon = new Pentagon(10);
            var actual = calc.GetArea(pentagon);
            Assert.AreEqual(expected, actual);
        }
    }
}
