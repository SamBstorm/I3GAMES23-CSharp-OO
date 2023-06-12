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
        public Nation nation;
        #endregion

        #region props
        public int Vie
        {
            get { return _vie; }
            private set {
                if (value < 0) { _vie = 0; }
                else if (value > VieMax) { _vie = VieMax; }
                else { _vie = value; }
            }
        }

        public int VieMax { get; private set; } = 100;

        public string Nom { get; set; }
        public int Puissance { get; set; }
        public int Defense { get; set; }

        public int NbUnite {
            get { return this.Vie / 10; }
        }
        #endregion

        #region methods
        public void SeBlesser(int degat)
        {
            int degatReduit = degat - Defense;
            if(degatReduit > 0) this.Vie -= degatReduit;
        }

        public void Tirer(Soldat adversaire)
        {
            if (adversaire is null) return; //Gestion d'exception (indiquer une erreur, un adversaire ne peut être null, voir plus loin)
            if (adversaire.nation == this.nation) return; //Gestion d'exception
            int degat = Puissance * NbUnite;
            adversaire.SeBlesser(degat);
        }

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
