using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal class Animal
    {
        private int _pv;
        private int PvMax { get; set; } = 20;

        public int Pv { 
            get { return _pv;}
            set {
                if (value < 0) _pv = 0;
                else if (value > PvMax) _pv = PvMax;
                else _pv = value;
            }
        }

        public int NbPattes { get; set; }
        public string Couleur { get; set; }
        public string Nom { get; set; }

        public virtual void SeDeplacer(string direction) {
            Console.WriteLine($"Je vais vers {direction}.");
        }
        public void SeNourir()
        {
            Console.WriteLine("Miam miam!");
        }

        public virtual void SExprimer()
        {
            Console.WriteLine($"Je suis {Nom} de couleur {Couleur}.");
        }
    }
}
