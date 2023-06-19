using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonusArbre.Models
{
    internal class Poirier : Arbre
    {
        public List<Poire> Recolte
        {
            get
            {
                return _recolte
                    //Fonction LinQ qui permet la transformation de chaque élément d'une collection
                    //Ici, chaque Fruit se voit Caster en Poire
                    .Select(f => (Poire)f)
                    //Fonction LinQ équivalent au ToArray(), mais cette fois retourne un object de type List<T>
                    .ToList();
            }
        }

        public override void Produire()
        {
            _recolte ??= new List<Fruit>();
            _recolte.Add(new Poire());
        }
    }
}
