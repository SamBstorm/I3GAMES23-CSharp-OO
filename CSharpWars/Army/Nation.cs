using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWars.Army
{
    internal class Nation
    {
        #region Fields
        private Dictionary<string, Soldat> _armee = new Dictionary<string, Soldat>();
        #endregion

        #region Props
        public string Nom { get; set; }
        public int Credit { get; private set; } = 10_000;

        public Soldat[] Armee
        {
            get
            {   
                List<Soldat> result = new List<Soldat>();
                
                foreach (Soldat soldat in _armee.Values)
                {
                    if(soldat.NbUnite > 0) result.Add(soldat);
                }

                return result.ToArray();

                /*//équivaut à la foreach du dessus
                
                foreach (KeyValuePair<string, Soldat> kvp in _armee)
                {
                    Soldat soldat = kvp.Value;
                    //...
                }
                

                //Avec LinQ : Plus facile de traiter une collection
                //return _armee.Values.Where(s => s.NbUnite >0).ToArray();
                */
            }
        }

        public Soldat this[string nom]
        {
            get {
                Soldat s = null;
                _armee.TryGetValue(nom, out s);
                return s;
            }

            set
            {
                if (value is null) return;      //Gestion d'exception
                if (nom != value.Nom) return;   //Gestion d'exception
                _armee[nom] = value;
            }
        }
        #endregion

        #region Methods
        public void Enroler(string nom)
        {
            if (_armee.ContainsKey(nom)) return;
            if (Credit < 1000) return;
            this.Credit -= 1000;
            Soldat s = new Soldat();
            s.Nom = nom;
            s.Puissance = 4;
            s.Defense = 3;
            s.nation = this;
            _armee.Add(nom, s);
        }
        #endregion
    }
}
