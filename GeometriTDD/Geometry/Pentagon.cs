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
                return Side;
            }
            return 0;
        }

        public override float GetPerimeter()
        {
            if (Side > 0)
            {
                return Side * 5;
            }
            return 0;
        }

    }
}