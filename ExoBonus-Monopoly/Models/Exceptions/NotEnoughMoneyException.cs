using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models.Exceptions
{
    internal class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException() : base("Le joueur n'a pas assez d'agent") {
        }
    }
}
