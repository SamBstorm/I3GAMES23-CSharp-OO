using Demo_Class.Locations;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture ferrari = new Voiture();
            ferrari.couleur = "Rouge";
            ferrari.marque = "Renault";
            ferrari.modele = "Twingo";
            ferrari.nbKm = 359_000;

            Voiture laFraise = ferrari;

            laFraise.Rouler(1000);

            Console.WriteLine(ferrari.nbKm);
            Console.WriteLine(laFraise.nbKm);
        }
    }
}