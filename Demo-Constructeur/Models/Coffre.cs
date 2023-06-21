using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur.Models
{
    internal class Coffre
    {
        protected Dictionary<string, int> _contenu;

        private Coffre() {
            _contenu = new Dictionary<string, int>();
        }

        public Coffre(string objetContenu, int quantite) : this()
        {
            //_contenu = new Dictionary<string, int>();
            _contenu.Add(objetContenu, quantite);
        }

        public Coffre(Dictionary<string, int> contenu)
        {
            _contenu = contenu;
        }

        public virtual Dictionary<string, int> Ouvrir() { 
            return _contenu;
        }
    }
}
