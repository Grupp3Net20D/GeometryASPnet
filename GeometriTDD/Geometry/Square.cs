using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en kvadrat, ärver ifrån GeometricThing
    /// </summary>
    public class Square : GeometricThing
    {
        /// <summary>
        /// Property för kvadratens Side, används i metoderna GetArea() och GetPerimeter()
        /// </summary>
        public float Side { get; set; }

        /// <summary>
        /// Konstruktor som använders sig av kvadratens Side.
        /// </summary>
        /// <param name="side"></param>
        public Square(float side)
        {
            Side = side;
        }

        /// <summary>
        /// En tom konstruktor som hanterar null värden.
        /// </summary>
        public Square()
        {

        }

        /// <summary>
        /// Denna metod används för att räkna ut kvadratens area.
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Side > 0)
            {
                return Side * Side;
            }
            else return 0;
        }

        /// <summary>
        /// Denna metod används för att räkna ut kvadratens omkrets.
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            if (Side > 0)
            {
                return Side * 4;
            }
            else return 0;
        }
    }
}
