using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHeritage.Models
{
    internal class Personnage
    {
        public int defBase;
        public int Def { 
            get
            {
                return defBase + DefBonus ;
            }
        }

        public int DefBonus
        {
            get
            {
                return (Casque?.pointBonus ?? 0) + (Buste?.pointBonus ?? 0) + (Jambiere?.pointBonus ?? 0);
            }
        }

        public Casque Casque { get; private set; }
        public Buste Buste { get; private set; }
        public Jambiere Jambiere { get; private set; }

        public int SEquiper(Equipement equipement)
        {
            if (equipement is null) return 0; //Gestion Exception
            //Mettre équipement

            /* Avec un switch
            
            switch (equipement)
            {
                case Casque c:
                    Casque = c;
                    break;

                case Buste b:
                    Buste = b;
                    break;

                case Jambiere j:
                    Jambiere = j;
                    break;
            }*/

            /* OU avec un if */
            if(equipement is Casque) Casque = (Casque)equipement;
            else if(equipement is Buste) Buste = (Buste)equipement;
            else if(equipement is Jambiere) Jambiere = (Jambiere)equipement;

            //Gestion des points bonus? Voir propriété            
            return equipement.pointBonus;
        }
    }
}
