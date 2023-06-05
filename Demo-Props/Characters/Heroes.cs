using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Props.Characters
{
    internal class Heroes
    {
        #region Champs/Variables membres
        private string _name;
        public int xp = 1000;
        #endregion

        #region Propriétés
        public string Name
        {
            // Accesseur (Getter) : permet de contrôler l'information sortante
            // nécessite toujours un return d'une valeur du type de la propriété
            get { 
                string result = _name.Substring(0,1).ToUpper() + _name.Substring(1).ToLower();
                return result; 
            }

            // Mutateur (Setter) : permet de contrôler l'information entrante
            // peut contenir la valeur à enregistrer sous le nom 'value'
            private set { _name = value.Trim(); }
        }
        public string Race { get; set; }

        public int Niveau {
            get {
                return this.xp / 10_000;
            }
                }

        #endregion

        /* En racourcis : propfull crée le champ privé et la propriété*/
        /*                prop crée une auto-propriété*/

        public void InitName(string name)
        {
            if(_name == null) Name = name;
        }
    }
}
