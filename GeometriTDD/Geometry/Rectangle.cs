using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en rektangel, ärver ifrån GeometricThing
    /// </summary>
    public class Rectangle : GeometricThing
    {
        /// <summary>
        /// Property för rektangelns Bas, används i metoderna GetArea() och GetPerimeter()
        /// </summary>
        public float Bas { get; set; }

        /// <summary>
        /// Property för rektangelns Höjd, används i metoderna GetArea() och GetPerimeter()
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Konstruktor som använder sig av rektangelns bas och höjd.
        /// </summary>
        /// <param name="bas"></param>
        /// <param name="height"></param>
        public Rectangle(float bas, float height)
        {
            Bas = bas;
            Height = height;
        }

        /// <summary>
        /// En tom konstruktor som hanterar null värden.
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Denna metoden används för att räkna ut rektangelns area.
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Bas > 0 && Height > 0)
            {
                return Bas * Height;
            }
            return 0;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut rektangelns omkrets.
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            if (Bas > 0 && Height > 0)
            {
                return Bas + Bas + Height + Height;
            }
            return 0;
        }
    }
}
