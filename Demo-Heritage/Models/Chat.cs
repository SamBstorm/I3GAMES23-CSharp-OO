using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal sealed class Chat : Animal
    {
        public int LongueurPoil { get; set; }
        public int LongueurQueue { get; set; }

        public new void SeDeplacer(string direction)
        {
            Console.WriteLine($"Je rôde vers {direction}.");
        }
        public override void SExprimer()
        {
            Console.WriteLine("Miaouw Miaouw! Je suis un chat!");
            base.SExprimer();
        }
    }
}
