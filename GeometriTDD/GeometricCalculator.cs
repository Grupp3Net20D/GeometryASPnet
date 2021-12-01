using System;
using System.Data;
using System.Linq.Expressions;

namespace GeometriTDD
{
    /// <summary>
    /// Denna klassen innehåller metoder som beräknar omkrets och area om en eller flera former.
    /// Alla metoder är baserade på klassen GeometricThing.
    /// </summary>
    public class GeometricCalculator
    {
        /// <summary>
        /// Denna metoden används för att räkna ut omkretsen av en geometrisk form (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetPerimeter(GeometricThing thing)
        {
            float perimeter = 0;
            if (thing != null)
            {
                float shape = thing.GetPerimeter();
                if (shape > 0)
                {
                    perimeter = shape;
                }
            }
            return perimeter;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut omkretsen av en eller flera geometrisk former (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="things"></param>
        /// <returns></returns>
        public float GetPerimeter(GeometricThing[] things)
        {
            float perimeter = 0;
            for (int i = 0; i < things.Length; i++)
            {
                if (things[i] != null)
                {
                    float shape = things[i].GetPerimeter();
                    if (shape > 0)
                    {
                        perimeter += things[i].GetPerimeter();
                    }
                    else if (shape == 0)
                    {
                        perimeter += 0;
                    }
                }
            }
            return perimeter;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut arean av en geometrisk form (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetArea(GeometricThing thing)
        {
            float area = 0;
            if (thing != null)
            {
                float shape = thing.GetArea();
                if (shape > 0)
                {
                    area = shape;
                }
            }
            return area;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut arean av en eller flera geometriska former (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="things"></param>
        /// <returns></returns>
        public float GetArea(GeometricThing[] things)
        {
            float area = 0;
            for (int i = 0; i < things.Length; i++)
            {
                if (things[i] != null)
                {
                    float shape = things[i].GetArea();
                    if (shape > 0)
                    {
                        area += things[i].GetArea();
                    }
                    else if (shape == 0)
                    {
                        area += 0;
                    }
                }
            }
            return area;
        }
    }
}
