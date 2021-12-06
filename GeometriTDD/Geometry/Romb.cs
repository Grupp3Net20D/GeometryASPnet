using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en romb, ärver ifrån GeometricThing
    /// </summary>
    public class Romb : GeometricThing
    {
        /// <summary>
        /// Properties för höjden och längden
        /// </summary>
        public float Heigth { get; set; }
        public float Side { get; set; }


        public Romb()
        {

        }

        public Romb(float heigth, float side)
        {
            Heigth = heigth;
            Side = side;
        }   

        public override float GetArea()
        {
            if(Heigth <=0 || Side <=0) return 0;

            return MathF.Round(Side * Heigth, 2);
        }

        public override float GetPerimeter()
        {
            if (Side <= 0) return 0;

            return MathF.Round(Side * 4, 2);
        }
    }
}
