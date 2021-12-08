using System;

namespace GeometriTDD.Geometry
{
    /// <summary>
    /// Klass som räknar ut arean och omkretsen av en liksidig pentagon.
    /// </summary>
    public class Pentagon : GeometricThing
    {
        public float Side { get; set; }

        public Pentagon(float side) 
        {
            Side = side;
        }

        public Pentagon()
        {

        }

        public override float GetArea()
        {
            if (Side > 0)
            {
                float perimeter = Side * 5;
                float tan = 1.45308506f;
                float apothem = Side / tan;
                return MathF.Round((perimeter * (apothem)) / 2, 2);
            }
            return 0;
        }

        public override float GetPerimeter()
        {
            if (Side > 0)
            {
                return MathF.Round(Side * 5,2);
            }
            return 0;
        }

    }
}