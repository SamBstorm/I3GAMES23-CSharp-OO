using ExoBonus_Tamagochi.Models;

namespace ExoBonus_Tamagochi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tamagochi!");
            Console.WriteLine("Voici votre nouvel ami!");
            Console.WriteLine("Veuillez choisir un nom :");

            Animal tama = new Animal();
            tama.Nom = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine($"-={tama.Nom}=-");
                Console.WriteLine("----------------");
                Console.WriteLine($"Faim : {tama.Faim}");
                Console.WriteLine($"Bonheur : {tama.Bonheur}");
                Console.WriteLine($"Santé : {tama.Sante}");
                Console.WriteLine("----------------");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Que voulez-vous faire :");
                    Console.WriteLine("1. Nourrir");
                    Console.WriteLine("2. Laver");
                    Console.WriteLine("3. Jouer");
                    int choix = int.Parse(Console.ReadLine());
                    switch (choix)
                    {
                        case 1:
                            tama.Manger();
                            Console.WriteLine("Miam!Miam!");
                            break;
                        case 2:
                            tama.Nettoyer();
                            Console.WriteLine("Plouf!Plouf!");
                            break;
                        case 3:
                            tama.Jouer();
                            Console.WriteLine("Youpie!Youpie!");
                            break;
                        default:
                            i--;
                            break;
                    }
                }
                tama.Vivre();
            } while (tama.EstVivant);
            Console.WriteLine("GameOver...");
        }
    }
}