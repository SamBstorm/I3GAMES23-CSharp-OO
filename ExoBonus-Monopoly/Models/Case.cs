using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models
{
    internal abstract class Case
    {

        public string NomCase { get; private set; }
        public List<Joueur> Visiteurs { get; private set; }
        public Case(string nomCase)
        {
            NomCase = nomCase;
            Visiteurs = new List<Joueur>();
        }

        public void NouveauVisiteur(Joueur joueurActuel)
        {
            Visiteurs.Add(joueurActuel);
        }
        public void QuitterCase(Joueur joueurActuel)
        {
            if (!Visiteurs.Contains(joueurActuel)) return;
            Visiteurs.Remove(joueurActuel);
        }
    }
}
