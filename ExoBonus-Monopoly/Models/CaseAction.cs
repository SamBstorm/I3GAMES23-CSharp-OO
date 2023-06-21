using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models
{
    internal class CaseAction : Case
    {
        public CaseAction(string nomCase) : base(nomCase)
        {
        }

        public void ExecuterAction(Joueur joueurActuel)
        {
            Console.WriteLine($"{joueurActuel.Nom} est sur la case {this.NomCase}!");
        }
    }
}
