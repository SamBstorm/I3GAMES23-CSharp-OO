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
        private Dictionary<string, Bataillon> _armee = new Dictionary<string, Bataillon>();
        #endregion

        #region Props
        public string Nom { get; set; }
        public int Credit { get; private set; } = 10_000;

        public Bataillon[] Armee
        {
            get
            {   
                List<Bataillon> result = new List<Bataillon>();
                
                foreach (Bataillon troupe in _armee.Values)
                {
                    if(troupe.NbUnite > 0) result.Add(troupe);
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

        public Bataillon this[string nom]
        {
            get {
                Bataillon s = null;
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
        public void EnrolerSoldat(string nom)
        {
            if (_armee.ContainsKey(nom)) return;
            if (Credit < 1000) return;
            this.Credit -= 1000;
            Soldat s = new Soldat();
            s.Nom = nom;
            s.nation = this;
            _armee.Add(nom, s);
        }

        public void EnrolerTank(string nom)
        {
            if (_armee.ContainsKey(nom)) return;
            if (Credit < 5000) return;
            this.Credit -= 5000;
            Tank t = new Tank();
            t.Nom = nom;
            t.nation = this;
            _armee.Add(nom, t);
        }

        public void Fusion(string nomBataillon1, string nomBataillon2)
        {
            //Je vérifie que j'ai bien obtenu les noms
            if (nomBataillon1 is null || nomBataillon2 is null) return; //Gestion d'exception

            //Je vérifie si les noms correspondent à des Soldats
            if (!_armee.ContainsKey(nomBataillon1)) return;             //Gestion d'exception
            if (!_armee.ContainsKey(nomBataillon2)) return;             //Gestion d'exception

            //Récupère les bataillons et vérifier qu'ils sont du même type

            Bataillon bataillon1 = _armee[nomBataillon1];
            Bataillon bataillon2 = _armee[nomBataillon2];

            if (bataillon1.GetType() != bataillon2.GetType()) return;  //Gestion d'exception

            //J'utilise l'opérateur + surchargé de mes Bataillons avec au préalable une conversion dans leur type respectif
            if(bataillon1 is Soldat) bataillon1 = (Soldat)bataillon1 + (Soldat)bataillon2;
            else if(bataillon1 is Tank) bataillon1 = (Tank)bataillon1 + (Tank)bataillon2;

            //Je supprime le Soldat avec 0 Vie
            _armee.Remove(nomBataillon2);
        }
        #endregion
    }
}
