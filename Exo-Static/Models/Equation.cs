using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Static.Models
{
    internal static class Equation
    {
        public static int A { get; set; }
        public static int B { get; set; }
        public static int C { get; set; }

        private static int _delta;
        public static bool EstPossible()
        {
            //int delta = (B * B) - 4 * A * C;
            _delta = (int)Math.Pow(B, 2) - 4 * A * C;
            
            //if (delta < 0) return false;
            //return true;

            return _delta >= 0;
        }
        public static bool Resoudre(out double? X1, out double? X2) {
            X1 = X2 = null;
            EstPossible();
            if(_delta < 0) return false;
            X1 = CalculX(-Math.Sqrt(_delta));
            X2 = CalculX(Math.Sqrt(_delta));
            return true;
        }
        private static double CalculX (double racine)
        {
            return (-B + racine) / (2 * A);
        }
    }
}
