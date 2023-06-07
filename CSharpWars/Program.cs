using CSharpWars.Army;

namespace CSharpWars
{
    internal class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bienvenu dans CSharp Wars!");

            /* Test Exercice 1
            Soldat valkyrie = new Soldat();
            valkyrie.Nom = "Valkyrie";
            valkyrie.Puissance = 4;
            valkyrie.Defense = 2;
            Console.WriteLine($"{valkyrie.Nom} sont pour le moment {valkyrie.NbUnite} soldat{((valkyrie.NbUnite>1) ? "s" : "" )}!");

            Soldat amazone = new Soldat();
            amazone.Nom = "Amazone";
            amazone.Puissance = 5;
            amazone.Defense = 1;
            Console.WriteLine($"{amazone.Nom} sont pour le moment {amazone.NbUnite} soldat{((amazone.NbUnite>1) ? "s" : "")}!");
            
            //Choix aléatoire de l'attaquant
            int random_result = RNG.Next(2);
            Soldat attaquant = valkyrie;
            Soldat defenseur = amazone;

            if (random_result == 1) { 
                attaquant = amazone;
                defenseur = valkyrie;
            }

            while(valkyrie.Vie > 0 && amazone.Vie > 0)
            {
                Console.WriteLine($"{attaquant.Nom} attaque!");
                attaquant.Tirer(defenseur);
                Console.WriteLine($"Il nous reste {defenseur.NbUnite} soldat{((defenseur.NbUnite>1) ? "s" : "")} dans le bataillon {defenseur.Nom}...");
                //Inversion
                Soldat temp = attaquant;
                attaquant = defenseur;
                defenseur = temp;
            }*/
            
            /* Test Exercice 2 */

            Nation rouge = new Nation();
            rouge.Nom = "Rouge";
            rouge.Enroler("Charlie");
            rouge.Enroler("Delta");
            rouge.Enroler("Echo");

            Nation bleue = new Nation();
            bleue.Nom = "Bleue";
            bleue.Enroler("Alpha");
            bleue.Enroler("Beta");
            bleue.Enroler("Omega");

            //Choix aléatoire de l'attaquant
            int random_result = RNG.Next(2);
            Soldat attaquant = rouge["Charlie"];
            Soldat defenseur = bleue["Omega"];

            if (random_result == 1)
            {
                attaquant = bleue["Omega"];
                defenseur = rouge["Charlie"];
            }

            while (attaquant.Vie > 0 && defenseur.Vie > 0)
            {
                Console.WriteLine($"{attaquant.Nom} de la nation {attaquant.nation.Nom} attaque!");
                attaquant.Tirer(defenseur);
                Console.WriteLine($"Il nous reste {defenseur.NbUnite} soldat{((defenseur.NbUnite > 1) ? "s" : "")} dans le bataillon {defenseur.Nom} de la nation {defenseur.nation.Nom}...");
                //Inversion
                Soldat temp = attaquant;
                attaquant = defenseur;
                defenseur = temp;
            }
            
        }
    }
}