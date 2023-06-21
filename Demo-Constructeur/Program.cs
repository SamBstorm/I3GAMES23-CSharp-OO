using Demo_Constructeur.Models;

namespace Demo_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffre coffre_vide = new Coffre();   //Si pas de ctor : Appel le ctor par defaut
                                                 //                 => _contenu va avoir null (valeur par defaut)
                                                 //Si au min. 1 ctor : Plus accès au ctor par defaut
                                                 //                    => exécute le bloc du ctor correspondant

            Coffre coffre_1 = new Coffre("or", 25);


            Dictionary<string, int> loot = new Dictionary<string, int>();
            loot.Add("Or", 150);
            loot.Add("Cuir", 5);
            loot.Add("Amulette", 1);
            Coffre coffre_2 = new Coffre(loot);

            CoffreFort coffre_fort = new CoffreFort("Vive les GAMES!");

            CoffreFort coffre_fort_1 = new CoffreFort("Hello", "Amulette");
            CoffreFort coffre_fort_2 = new CoffreFort("Hello", "Or", 150);
            CoffreFort coffre_fort_3 = new CoffreFort("Hello", loot);
        }
    }
}