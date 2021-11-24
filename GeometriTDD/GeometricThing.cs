using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD
{
    /// <summary>
    /// En abstrakt klass som fungerar som en mall för de olika geometriska formerna (Triangle, Square, Rectangle, Circle).
    /// </summary>
    public abstract class GeometricThing
    {
        /// <summary>
        /// Abstrakt metod som räknar ut arean, används som en mall för de olika geometriska formerna (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <returns></returns>
        public abstract float GetArea();

        /// <summary>
        /// Abstrakt metod som räknar ut omkretsen, används som en mall för de olika geometriska formerna (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <returns></returns>
        public abstract float GetPerimeter();
    }

}
