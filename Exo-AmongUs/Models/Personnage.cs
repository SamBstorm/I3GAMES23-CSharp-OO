using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_AmongUs.Models
{
    internal class Personnage : IJoueur, ITueur
    {
        public string Name { get; set; }

        public bool IsAlive { get; private set; } = true;

        public void Kill(IJoueur dead)
        {
            if (dead is null) return; //Gestion exception
            if (!dead.IsAlive) return; //Gestion exception
            if (!this.IsAlive) return; //Gestion exception
            ((Personnage)dead).IsAlive = false;
        }

        public string Vote(IJoueur otherPlayer)
        {
            if (otherPlayer is null) return null; //Gestion exception
            if (!otherPlayer.IsAlive) return null; //Gestion exception
            if (!this.IsAlive) return null; //Gestion exception
            return otherPlayer.Name;
        }
    }
}
