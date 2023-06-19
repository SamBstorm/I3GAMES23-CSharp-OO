using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Soldat : Bataillon
    {
        #region Constructors
        public Soldat() : base(4,3)
        {
            
        }
        #endregion

        #region methods

        public static Soldat operator + (Soldat left, Soldat right)
        {
            if(right.Vie > 0)
            {
                left.Vie = left.Vie + right.Vie;
                right.Vie = 0;
            }
            return left;
        }
        #endregion
    }
}
