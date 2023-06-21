using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models
{
    internal class Joueur
    {

        public string Nom { get; private set; }
        public EnumPion Pion { get; private set; }
        public int Solde { get; private set; }
        public List<CasePropriete> Proprietes { get; private set; }
        public Joueur(string nom, EnumPion pion)
        {
            Nom = nom;
            Pion = pion;
            Solde = 10_000;
            Proprietes = new List<CasePropriete>();
        }

        public void Payer(int somme)
        {
            if(somme <= 0) return; //Gestion Exception
            if(Solde >= somme) Solde -= somme;
        }
        public void DevenirProprio(CasePropriete propriete) {
            if (propriete.Proprietaire != this) return;
            Proprietes.Add(propriete);
        }

    }
}
