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
        #endregion

        #region Propriétés
        public string Nom { get; set; }
        public int Bonheur
        {
            get { return _bonheur; }
            private set
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
            private set
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
            private set
            {
                /* Sans méthodes
                if (value < 0) _sante = 0;
                else if (value > 5) _sante = 5;
                else _sante = value;*/
                _sante = CheckStats(value);
            }
        }
        public bool EstVivant { get { return _estVivant; } }
        #endregion

        #region Méthodes
        public void Manger()
        {
            if (_action > 0 && _estVivant)
            {
                Faim += 2;
                Bonheur += 1;
                _action--;
            }
        }

        public void Jouer()
        {
            if (_action > 0 && _estVivant)
            {
                Bonheur += 3;
                _action--;
            }
        }

        public void Nettoyer()
        {
            if (_action > 0 && _estVivant)
            {
                Sante += 5;
                Bonheur += 1;
                _action--;
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
            _action = 5;

        }
        private int CheckStats(int value, int min = 0, int max = 5)
        {
            if (value < min) return min;
            else if (value > max) return max;
            else return value;
        } 
        #endregion
    }
}
