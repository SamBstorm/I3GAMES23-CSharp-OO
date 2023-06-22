using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Monopoly.Models
{
    internal class Jeu
    {
        public List<Case> Plateau { get; private set; }
        public List<Joueur> Joueurs { get; private set; }

        public Jeu() {
            #region Créer Plateau
            Plateau = new List<Case>();
            Plateau.Add(new CaseAction("Départ"));
            Plateau.Add(new CasePropriete("Accueil", EnumCouleur.Marron, 10));
            Plateau.Add(new CasePropriete("Caffet'", EnumCouleur.Marron, 12));
            Plateau.Add(new CaseAction("Chance"));
            Plateau.Add(new CasePropriete("Cage Ascenceur Gauche", EnumCouleur.BleuCiel, 16));
            Plateau.Add(new CasePropriete("Cage Ascenceur Droite'", EnumCouleur.BleuCiel, 18));
            Plateau.Add(new CaseAction("Prison"));
            Plateau.Add(new CasePropriete("Secrétariat", EnumCouleur.Mauve, 20));
            Plateau.Add(new CasePropriete("Imprimante", EnumCouleur.Mauve, 22));
            Plateau.Add(new CaseAction("Caisse de communauté"));
            Plateau.Add(new CasePropriete("Grille côté Métro", EnumCouleur.Orange, 26));
            Plateau.Add(new CasePropriete("Grille côté Parc'", EnumCouleur.Orange, 28));
            Plateau.Add(new CaseAction("Parc Gratuit"));
            Plateau.Add(new CasePropriete("Salle OMI", EnumCouleur.Rouge, 30));
            Plateau.Add(new CasePropriete("Salle ASR'", EnumCouleur.Rouge, 32));
            Plateau.Add(new CaseAction("Chance"));
            Plateau.Add(new CasePropriete("Salle Data Analyst", EnumCouleur.Jaune, 36));
            Plateau.Add(new CasePropriete("Salle Web'", EnumCouleur.Jaune, 38));
            Plateau.Add(new CaseAction("Aller en prison"));
            Plateau.Add(new CasePropriete("Salle WAD", EnumCouleur.Vert, 40));
            Plateau.Add(new CasePropriete("Salle Unity'", EnumCouleur.Vert, 42));
            Plateau.Add(new CaseAction("Caisse de communauté"));
            Plateau.Add(new CasePropriete("Bureau Sonia", EnumCouleur.Bleu, 48));

            //Plateau.Add(new CasePropriete("Bureau Nicole'", EnumCouleur.Bleu, 50));
            //Pour la démo Exception :
            Plateau.Add(new CasePropriete("Bureau Nicole'", EnumCouleur.Bleu, 50_000));
            #endregion
            Joueurs = new List<Joueur>();
        }

        public void AjouterJoueur(string nom, EnumPion pion)
        {
            Joueurs.Add(new Joueur(nom, pion));
        }
    }
}
