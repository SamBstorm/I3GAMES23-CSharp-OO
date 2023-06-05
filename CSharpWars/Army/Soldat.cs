using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Soldat
    {
        #region fields
        private int _vie = 100;
        #endregion

        #region props
        public int Vie
        {
            get { return _vie; }
            private set { 
                if (value < 0 ) { _vie = 0; }
                else _vie = value;
            }
        }

        public int VieMax { get; private set; } = 100;

        public string Nom { get; set; }
        public int Puissance { get; set; }
        public int Defense { get; set; }
        #endregion

        #region methods

        #endregion
    }
}
