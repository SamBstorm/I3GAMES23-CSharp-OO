using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonusArbre.Models
{
    internal class Pommier : Arbre
    {
        public List<Pomme> Recolte
        {
            get
            {
                List<Pomme> pommes = new List<Pomme>();
                foreach (Fruit fruit in _recolte)
                {
                    pommes.Add((Pomme)fruit);
                }
                return pommes;
            }
        }
        public override void Produire()
        {
            _recolte ??= new List<Fruit>();
            _recolte.Add(new Pomme());
        }
    }
}
