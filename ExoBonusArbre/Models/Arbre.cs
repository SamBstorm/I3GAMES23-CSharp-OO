using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonusArbre.Models
{
    internal abstract class Arbre : IArbre, IMareche
    {
        protected List<Fruit> _recolte;
        public List<Fruit> Secouer() {
            return _recolte;
        }

        public abstract void Produire();
    }
}
