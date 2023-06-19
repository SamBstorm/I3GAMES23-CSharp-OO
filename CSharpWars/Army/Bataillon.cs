using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Bataillon
    {
        protected int _ratio;

        private int _vie;

        public int Vie
        {
            get
            {
                return _vie;
            }
            protected set
            {
                if (value < 0) _vie = 0;
                else if (value > VieMax) _vie = VieMax;
                else _vie = value;
            }
        }
        public int VieMax { get { return 100 * _ratio; } }

        public int NbUnite
        {
            get { return _vie / (10 * _ratio); }
        }

        public Nation nation;
        public string Nom { get; set; }
        public int Puissance { get; set; }
        public int Defense { get; set; }

        //Constructeur (défini les valeurs de base de l'object)
        public Bataillon(int puissance, int defense)
        {
            _ratio = 1;
            Vie = VieMax;
            Puissance = puissance;
            Defense = defense;
        }

        public void SeBlesser(int degat)
        {
            int degatReduit = degat - Defense;
            if (degatReduit > 0) this.Vie -= degatReduit;
        }
        public void Tirer(Bataillon adversaire)
        {
            if (adversaire is null) return; //gestion d'exception
            if (adversaire.nation == nation) return; // Gestion d'exception
            int degat = Puissance * NbUnite;
            adversaire.SeBlesser(degat);
        }
    }
}
