using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en cirkel, ärver ifrån GeometricThing
    /// </summary>
    public class Circle : GeometricThing
    {
        /// <summary>
        /// Property för cirkelns Radie, används i metoderna GetArea() och GetPerimeter().
        /// </summary>
        public float Radie { get; set; }

        /// <summary>
        /// Konstruktor som använder sig av cirkelns radie.
        /// </summary>
        /// <param name="radie"></param>
        public Circle(float radie)
        {
            Radie = radie;
        }

        /// <summary>
        /// En tom konstruktor som hanterar null värden.
        /// </summary>
        public Circle()
        {

        }

        /// <summary>
        /// Denna metoden räknar ut arean av en cirkel.
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Radie > 0)
            {
                return Radie * Radie * 3.1415926535f;
            }
            return 0;
        }

        /// <summary>
        /// Denna metoden räknar ut omkretsen av en cirkel.
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            if (Radie > 0)
            {
                return (Radie * 2) * 3.1415926535f;
            }
            return 0;
        }
    }
}
