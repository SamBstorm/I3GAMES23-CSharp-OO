using Demo_Props.Characters;

namespace Demo_Props
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heroes joueur = new Heroes();
            Console.WriteLine("Bonjour aventurier! Quel est votre nom?");
            joueur.InitName(Console.ReadLine());
            Console.WriteLine($"Enchanté {joueur.Name}!");
            //joueur._name = "toto"; //La variable _name est private, donc inaccessible pour Program

            Console.WriteLine("Et de quel race êtes-vous?");
            joueur.Race = Console.ReadLine();
            Console.WriteLine($"Vu votre tête, je me doutais que vous étiez un {joueur.Race}!");

            Console.WriteLine("Ho! Attention un loup vous attaque!");
            Console.WriteLine("*Wouff!*");
            Console.WriteLine($"Vous passez du niveau {joueur.Niveau}...");
            joueur.xp += 52_000;
            Console.WriteLine($"au niveau {joueur.Niveau}!");
        }
    }
}