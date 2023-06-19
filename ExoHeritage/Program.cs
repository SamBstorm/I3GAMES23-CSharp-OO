using ExoHeritage.Models;

namespace ExoHeritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnage heroes = new Personnage() { defBase = 5 };

            Casque c1 = new Casque() { nom = "Heaume Contre-feu", pointBonus = 5 };
            Casque c2 = new Casque() { nom = "Casque pare-foudre", pointBonus = 3 };

            Buste b1 = new Buste() { nom = "Plaston Divin", pointBonus = 7 };
            Buste b2 = new Buste() { nom = "Toge du mage", pointBonus = 2 };

            Jambiere j1 = new Jambiere() { nom = "Jambières de fer", pointBonus = 3 };
            Jambiere j2 = new Jambiere() { nom = "Spartiates de course", pointBonus = 1 };

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(c1);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(b1);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(j1);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(c2);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(b2);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");

            heroes.SEquiper(j2);

            Console.WriteLine($"Mon héros a pour casque : {heroes.Casque?.nom ?? "Aucun"} ; pour buste : {heroes.Buste?.nom ?? "Aucun"} ; et pour jambières : {heroes.Jambiere?.nom ?? "Aucun"}. Sa défense est de {heroes.Def}(+{heroes.DefBonus}).");
        }
    }
}