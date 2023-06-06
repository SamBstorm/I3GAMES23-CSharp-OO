using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Nation
    {
        #region Fields
        private Dictionary<string, Soldat> _armee;
        #endregion

        #region Props
        public string Nom { get; set; }
        public int Credit { get; private set; } = 10_000;
        #endregion

        #region Methods

        #endregion
    }
}
