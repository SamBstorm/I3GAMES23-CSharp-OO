using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_AmongUs.Models
{
    internal interface ITueur : IJoueur
    {
        void Kill(IJoueur dead);
    }
}
