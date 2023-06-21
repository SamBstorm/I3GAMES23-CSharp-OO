using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_AmongUs.Models
{
    internal interface IJoueur
    {
        string Name { get; set; }
        bool IsAlive { get; }

        string Vote(IJoueur otherPlayer);
    }
}
