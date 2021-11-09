using System;
using System.Drawing;

namespace BrideAndGroomLibrary
{
    public class BrideAndGroom : Person
    {
        private Properties _desiredProperties;

        private Properties _properties;
        
        public BrideAndGroom(Gender gender, Properties desiredProperties, Properties properties) : base(gender)
        {
            _desiredProperties = desiredProperties;
            _properties = properties;
        }
        
        /// <summary>
        ///     Возвращает разницу между двумя цветами.
        /// </summary>
        /// <param name="clr1">Первый цвет.</param>
        /// <param name="clr2">Второй цвет.</param>
        /// <returns>Разница между цветами.</returns>
        private static int ColorDistance(Color clr1, Color clr2)
        {
            var rDiff = clr2.R - clr1.R;
            var gDiff = clr2.G - clr1.G;
            var bDiff = clr2.G - clr1.B;

            // x^2 + y^2 + z^2 = r^2
            return rDiff * rDiff + gDiff * gDiff + bDiff * bDiff;
        }
    }
}
