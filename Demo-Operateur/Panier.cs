using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operateur
{
    internal class Panier
    {
        private readonly List<Fruit> _fruits = new List<Fruit>();

        public void AddFruit(Fruit f)
        {
            _fruits.Add(f);
        }

        public static Panier operator +(Panier left, Panier right) { 
            Panier result = new Panier();

            foreach (Fruit f in left._fruits)
            {
                result.AddFruit(f);
            }

            foreach (Fruit f in right._fruits)
            {
                result.AddFruit(f);
            }

            return result;
        }
    }
}
