using ExoBonus_Monopoly.Models;

namespace ExoBonus_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Démo Exception DivideByZero
             * int zero = 0;
            try
            {
                int result = 5 / zero;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Result n'est pas calculable car : {e.Message}");
            }*/
            Jeu partie1 = new Jeu();
            partie1.AjouterJoueur("Feryel", EnumPion.Dino);
            partie1.AjouterJoueur("Cécile", EnumPion.Bateau);
            partie1.AjouterJoueur("Carol", EnumPion.Voiture);
            partie1.AjouterJoueur("Djihen", EnumPion.Fer);

            Case currentCase = partie1.Plateau[3];
            Joueur j1 = partie1.Joueurs[0];
            currentCase.NouveauVisiteur(j1);
            switch (currentCase)
            {
                case CaseAction action:
                    action.ExecuterAction(j1);
                    break;
                case CasePropriete propriete:
                    propriete.AchatPar(j1);
                    break;
            }

            currentCase = partie1.Plateau[23];
            Joueur j2 = partie1.Joueurs[1];
            currentCase.NouveauVisiteur(j2);
            switch (currentCase)
            {
                case CaseAction action:
                    action.ExecuterAction(j2);
                    break;
                case CasePropriete propriete:
                    propriete.AchatPar(j2);
                    break;
            }
        }
    }
}