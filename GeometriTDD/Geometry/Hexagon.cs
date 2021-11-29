using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriTDD.Geometry
{

    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en hexagon, ärver ifrån GeometricThing
    /// </summary>
   public class Hexagon : GeometricThing
    {
        /// <summary>
        /// Property för hexagon Side, används i metoderna GetArea() och GetPerimeter()
        /// </summary>
        public float Side { get; set; }

        /// <summary>
        /// Konstruktor som använders sig av hexagon Side.
        /// </summary>
        /// <param name="side"></param>
        public Hexagon(float side)
        {
            Side = side;
        }
        /// <summary>
        /// En tom konstruktor som hanterar null värden.
        /// </summary>
        public Hexagon()
        {

        }
        /// <summary>
        /// Denna metod används för att räkna ut hexagon area.
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Side > 0)
            {
                return MathF.Round( (3 * MathF.Sqrt(3f) * Side * Side) / 2,2);
                
            }
            return 0;
        }
        /// <summary>
        /// Denna metod används för att räkna ut hexagon omkrets.
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            if (Side > 0)
            {
                return Side * 6;
            }
            return 0;
        }
    }
}
