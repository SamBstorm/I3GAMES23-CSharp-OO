using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Bataillon
    {
        /*Notion d'abstraction/constructeur

        //private int _vie;
        //public int Vie
        //{
        //    get
        //    {
        //        return _vie;
        //    }
        //    private set
        //    {
        //        if (value < 0) _vie = 0;
        //        else if (value > VieMax) _vie = VieMax;
        //        else _vie = value;
        //    }
        //}
        //public int VieMax { get; private set; }
        //public int NbUnite
        //{
        //    get { return this.Vie / 10; }
        //}*/

        public Nation nation;
        public string Nom { get; set; }
        public int Puissance { get; set; }
        public int Defense { get; set; }

        public virtual void SeBlesser(int degat)
        {
            int degatReduit = degat - Defense;
            /*Plus accès à la vie*/
            //if (degatReduit > 0) this.Vie -= degatReduit;
        }

        /* Paramètre de mauvais type
        //public void Tirer(Soldat adversaire)
        //{
        //    if (adversaire is null) return; //Gestion d'exception (indiquer une erreur, un adversaire ne peut être null, voir plus loin)
        //    if (adversaire.nation == this.nation) return; //Gestion d'exception
        //    int degat = Puissance * NbUnite;
        //    adversaire.SeBlesser(degat);
        //}
        */
    }
}
