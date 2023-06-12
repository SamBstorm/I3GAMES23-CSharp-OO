using Demo_Heritage.Models;

namespace Demo_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Poisson nemo = new Poisson();
            nemo.NbPattes = 0;
            nemo.Couleur = "Orange";
            nemo.Pv = 20;
            nemo.Nom = "Némo";
            //nemo.PvMax = 10;      //Poisson est enfant de Animal :
                                    //Animal peut accéder au PvMax car private
                                    //Poisson est un animl donc contient les valeurs de PvMax
                                    //Poisson ne peut lire ou écrire PvMax car private à Animal

            nemo.GetType();         //La méthode GetType() provient de la class Object, il s'agit de la class parent de tout objet

            nemo.TypeEau = "Salée";
            nemo.NbNageoires = 5;

            Chat tom = new Chat();
            tom.Nom = "Tom";
            tom.Couleur = "Gris";
            tom.NbPattes = 4;
            tom.Pv = 20;

            //tom.NbNageoires = 0;      //tom est un Animal, et un Animal n'est pas un Poisson
            //tom.TypeEau = "Douce";    //Il ne connait pas les caractéristiques du Poisson

            nemo.SeDeplacer("tout droit");
            tom.SeDeplacer("tout droit");

            Animal a_nemo = nemo;
            Animal a_tom = tom;

            a_nemo.SeDeplacer("tout droit");
            a_tom.SeDeplacer("tout droit");

            nemo.SExprimer();
            tom.SExprimer();
        }
    }
}