using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal class Poisson : Animal
    {
        public int NbNageoires { get; set; }
        public string TypeEau { get; set; }

        public override void SeDeplacer(string direction)
        {
            Console.WriteLine($"Je nage vers {direction}.");
        }

        public override void SExprimer()
        {
            Console.WriteLine("Blurp blurp! Je suis un poisson!");
            base.SExprimer();
        }
    }
}
