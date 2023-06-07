namespace Demo_Operateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panier p1 = new Panier();
            p1.AddFruit(new Fruit() { Nom = "Pomme" });
            p1.AddFruit(new Fruit() { Nom = "Pomme" });
            p1.AddFruit(new Fruit() { Nom = "Pomme" });
            p1.AddFruit(new Fruit() { Nom = "Orange" });

            // p1 contient 3 Pommes et 1 Orange

            Panier p2 = new Panier();
            p2.AddFruit(new Fruit() { Nom = "Orange" });
            p2.AddFruit(new Fruit() { Nom = "Fraise" });
            p2.AddFruit(new Fruit() { Nom = "Orange" });

            // p2 contient 2 Oranges et 1 Fraise

            Panier resultatRecolte = p1 + p2;
        }
    }
}