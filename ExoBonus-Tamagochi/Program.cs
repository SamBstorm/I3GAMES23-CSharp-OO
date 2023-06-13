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
                Console.WriteLine(tama);
                while(tama.Action > 0) { 
                    Console.WriteLine("Que voulez-vous faire :");
                    Console.WriteLine("1. Nourrir");
                    Console.WriteLine("2. Laver");
                    Console.WriteLine("3. Jouer");
                    if(tama is Chien) Console.WriteLine("4. Promener");
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
                        case 4 when tama is Chien tama_chien:
                            tama_chien.Promener();
                            Console.WriteLine("*Agite sa queue!*");
                            break;
                    }
                }
                tama.Vivre();
                if (tama.Temps >= 3)
                {
                    tama = tama.Evoluer();                    
                }
            } while (tama.EstVivant);
            Console.WriteLine("GameOver...");
        }
    }
}