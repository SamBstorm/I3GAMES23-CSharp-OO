using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonusArbre.Models
{
    //Plus facile de créer le contenu d'une class si celle-ci implémente une interface
    //Les éléments obligatoires de l'interface peuvent être généré par VS
    //(Ampoule avec la croix ou 'ctrl + ;' -> "Implémenter interface")
    internal class Buisson : IArbre
    {
        public void Produire()
        {
            throw new NotImplementedException(); //Gestion d'exception, lorsque l'on implémente une interface, le contenu des fonctions ne sont pas encore défini, donc elles sont dites Non-Implémentées
        }

        public List<Fruit> Secouer()
        {
            throw new NotImplementedException();
        }
    }
}
