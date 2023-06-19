using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Tank : Bataillon
    {
        public Tank() : base(7, 6)
        {
            _ratio = 4;
            Vie = VieMax;
        }
        
        public static Tank operator + (Tank left, Tank right)
        {
            if(right.Vie > 0)
            {
                left.Vie += right.Vie;
                right.Vie = 0;
            }

            return left;
        }
    }
}
