using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class.Locations
{
    internal class Voiture
    {
        public string marque;
        public string couleur;
        public string modele;
        public string carburant;
        public int nbPassagers;
        public int nbKm;
        public DateTime dateFabrication;

        public void Rouler(int km)
        {
            this.nbKm += km;
        }

    }
}
