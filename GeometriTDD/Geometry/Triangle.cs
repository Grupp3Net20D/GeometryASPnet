using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en triangel, ärver ifrån GeometricThing.
    /// Bestämde mig för att bara ha denna metod för att räkna ut liksidiga trianglar, kan fokusera mer på tester i sådanna fall.
    /// </summary>
    public class Triangle : GeometricThing
    {
        /// <summary>
        /// Property för triangelns Side, används i GetArea() och GetPerimeter().
        /// </summary>
        public float Side { get; set; }

        /// <summary>
        /// Konstruktor som använder sig av triangelns Side.
        /// </summary>
        /// <param name="side"></param>
        public Triangle(float side)
        {
            Side = side;
        }

        /// <summary>
        /// En tom konstruktor som hanterar null värden.
        /// </summary>
        public Triangle()
        {

        }

        /// <summary>
        /// Denna metod används för att räkna triangelns area.
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Side > 0)
            {
                return Side * Side / 2;
            }
            return 0;
        }

        /// <summary>
        /// Denna metod används för att räkna ut triangelns omkrets.
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            if (Side > 0)
            {
                return Side * 3;
            }
            return 0;
        }
    }
}
