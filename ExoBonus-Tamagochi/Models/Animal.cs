using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Tamagochi.Models
{
    internal class Animal
    {
        #region Champs
        private Random _rng = new Random();

        private DateTime _dateNaissance = DateTime.Now;
        private int _bonheur = 0;
        private int _faim = 0;
        private int _sante = 0;
        private int _compteur = 0;
        private int _action = 5;
        private bool _estVivant = true;
        //private int _temps = 0;       //Devenu auto-propriété
        #endregion

        #region Propriétés
        public string Nom { get; set; }
        public int Bonheur
        {
            get { return _bonheur; }
            protected set
            {
                /* Sans méthodes
                if (value < 0) _bonheur = 0;
                else if(value > 5) _bonheur = 5;
                else _bonheur = value;
                */
                _bonheur = CheckStats(value);
            }
        }
        public int Faim
        {
            get { return _faim; }
            protected set
            {
                /* Sans méthodes
                if (value < 0) _faim = 0;
                else if (value > 5) _faim = 5;
                else _faim = value;*/
                _faim = CheckStats(value);
            }
        }
        public int Sante
        {
            get { return _sante; }
            protected set
            {
                /* Sans méthodes
                if (value < 0) _sante = 0;
                else if (value > 5) _sante = 5;
                else _sante = value;*/
                _sante = CheckStats(value);
            }
        }
        public bool EstVivant { get { return _estVivant; } }
        public int Action {
            get { return _action; }
            protected set
            {
                _action = value;
                //if(_action==0) Vivre();
            }
        }

        public int Temps { get; private set; } = 0;
        #endregion

        #region Méthodes
        public virtual void Manger()
        {
            if (Action > 0 && _estVivant)
            {
                Faim += 2;
                Bonheur += 1;
                Action--;
            }
        }

        public void Jouer()
        {
            if (Action > 0 && _estVivant)
            {
                Bonheur += 3;
                Action--;
            }
        }

        public virtual void Nettoyer()
        {
            if (Action > 0 && _estVivant)
            {
                Sante += 5;
                Bonheur += 1;
                Action--;
            }
        }

        private void FaireCaca()
        {
            Sante = 0;
        }

        private void Mourir()
        {
            Sante = 0;
            Faim = 0;
            Bonheur = 0;
            _estVivant = false;
        }

        public void Vivre()
        {
            if (Faim == 0) _compteur++;
            if (Bonheur == 0) _compteur++;
            if (Sante == 0) _compteur++;
            if (_compteur >= 3)
            {
                Mourir();
                return;
            }
            int randomResult = _rng.Next(1, 6);
            if (randomResult == 1) FaireCaca();
            else if (Faim == 5 && randomResult == 2) FaireCaca();
            Faim--;
            Bonheur--;
            Sante--;
            Action = 5;
            Temps++;

        }
        private int CheckStats(int value, int min = 0, int max = 5)
        {
            if (value < min) return min;
            else if (value > max) return max;
            else return value;
        }

        public override string ToString()
        {
            return @$"-={Nom}=-
----------------
Faim : {Faim}
Bonheur : {Bonheur}
Santé : {Sante}
----------------";
        }

        public Chien Evoluer()
        {
            Chien evolution = new Chien();
            evolution.Nom = this.Nom;
            evolution.Sante = this.Sante;
            evolution.Bonheur = this.Bonheur;
            evolution.Faim = this.Faim;
            evolution.Temps = this.Temps;
            evolution._dateNaissance = this._dateNaissance;
            evolution._estVivant = this._estVivant;
            evolution._action = this._action;
            evolution._compteur = this._compteur;
            return evolution;
        }
        #endregion
    }
}
