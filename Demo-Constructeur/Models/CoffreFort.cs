using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur.Models
{
    internal class CoffreFort : Coffre
    {
        private string _codeSecret;
        public string CodeEntre { get; private set; }

        public CoffreFort(string code)
        {
            _codeSecret = code;
        }

        public CoffreFort(string code, string objetContenu) : base (objetContenu, 1)
        {
            _codeSecret = code;
        }

        public CoffreFort(string code, string objetContenu, int quantite) : base (objetContenu, quantite)
        {
            _codeSecret = code;
            //_contenu.Add(objetContenu, quantite);
        }

        public CoffreFort(string code, Dictionary<string, int> contenu) : base (contenu)
        {
            _codeSecret = code;
        }

        public void EntrerCode(string code)
        {
            CodeEntre = code;
        }

        public override Dictionary<string, int> Ouvrir()
        {
            if(CodeEntre == _codeSecret) return _contenu;
            return null;
        }
    }
}
