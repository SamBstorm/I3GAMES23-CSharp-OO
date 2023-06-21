using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models
{
    internal class Jeu
    {
        public List<Case> Plateau { get; private set; }
        public List<Joueur> Joueurs { get; private set; }
    }
}
