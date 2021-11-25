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
        public float Length { get; set; }
      
        public Romb()
        {

        }

        public Romb(float heigth, float length)
        {
            Heigth = heigth;
            Length = length;
        }



        public override float GetArea()
        {
            return Heigth * Length;
        }

        public override float GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
