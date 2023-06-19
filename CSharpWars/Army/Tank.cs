using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Tank : Bataillon
    {
        private int _vie = 400;

        public int Vie { get
            { 
                return _vie; 
            }
            private set {
                if(value < 0) _vie = 0;
                else if (value > VieMax) _vie = VieMax;
                else _vie = value;
            } 
        } 
        public int VieMax { get; private set; } = 400;

        public int NbUnite
        {
            get { return _vie / 40; }
        }

        public override void SeBlesser(int degat)
        {
            int degatReduit = degat - Defense;
            if (degatReduit > 0) Vie -= degatReduit;
        }

        public void Tirer(Tank adversaire)
        {
            if (adversaire is null) return; //gestion d'exception
            if (adversaire.nation == nation) return; // Gestion d'exception
            int degat = Puissance * NbUnite;
            adversaire.SeBlesser( degat );
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
