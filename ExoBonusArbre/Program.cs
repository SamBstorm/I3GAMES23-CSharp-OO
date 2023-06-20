using ExoBonusArbre.Models;

namespace ExoBonusArbre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Arbre> verger = new List<Arbre>();
            verger.Add(new Pommier());
            verger.Add(new Poirier());
            for (int i = 0; i < 9; i++)
            {
                foreach (Arbre a in verger)
                {
                    a.Produire();
                }
            }
            Console.WriteLine($"Dans mon Pommier il y a {((Pommier)verger[0]).Recolte.Count} pommes!");
            Console.WriteLine($"Dans mon Poirier il y a {((Poirier)verger[1]).Recolte.Count} poires!");

            Pommier pommier = new Pommier();
            IArbre arbre_1 = pommier;
            arbre_1.Produire();

            IMareche proprio = pommier;
            proprio.Secouer();
        }
    }
}