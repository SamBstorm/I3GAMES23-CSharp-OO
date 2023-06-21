using Exo_AmongUs.Models;

namespace Exo_AmongUs
{
    internal class Program
    {
        private static Random _rng = new Random();
        static void Main(string[] args)
        {
            /* Ancienne version
             * Console.WriteLine("Among US Console edition!");
            List<IJoueur> players = new List<IJoueur>();
            Console.WriteLine("Combien de joueur ? (3 à infini)");
            int nbPlayer = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbPlayer; i++)
            {
                Console.Clear();
                Console.WriteLine($"Indiquez votre nom Joueur {i+1}:");
                string name = Console.ReadLine();
                players.Add(new Personnage() { Name = name });
            }

            ITueur killer = (Personnage)players[_rng.Next(players.Count)];

            do
            {
                //Création de l'urne de vote par dictionnaire
                Dictionary<string, int> votes = new Dictionary<string, int>();
                //Demande à chaque joueur de voter
                foreach (IJoueur currentPlayer in players)
                {
                    //Vote seulement si en vie...
                    if (currentPlayer.IsAlive)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous votez pour éliminer :");
                        //Affiche la liste des joueurs
                        for (int i = 0;i < nbPlayer; i++)
                        {
                            if (players[i].IsAlive)
                                Console.WriteLine($"{i+1}. {players[i].Name}");
                        }
                        //Récupère le choix de vote du joueur
                        Console.WriteLine("Veuillez entrer le numéro du joueur :");
                        int choice = int.Parse(Console.ReadLine());
                        string name = currentPlayer.Vote(players[choice-1]);
                        //Placer le vote dans l'urne
                        if (votes.ContainsKey(name)) votes[name]++;
                        else votes.Add(name,1);
                    }
                }
                //Dépouillage des votes
                string choosenOne = "";
                int maxVote = 0;
                bool isFirst = true;
                //Vérifie le vote le plus grand
                foreach (KeyValuePair<string, int> kvp in votes)
                {
                    if(isFirst)
                    {
                        choosenOne = kvp.Key;
                        maxVote = kvp.Value;
                        isFirst = false;
                    }
                    else
                    {
                        if(kvp.Value > maxVote)
                        {
                            choosenOne = kvp.Key;
                            maxVote = kvp.Value;
                        }
                    }
                }
                //Cherche le joueur correspondant au vote
                foreach (IJoueur player in players)
                {
                    if (player.Name == choosenOne) 
                        //Un joueur doit redevenir un Personnage pour devenir un tueur
                        ((ITueur)((Personnage)player)).Kill(player);
                }
                //Phase du tueur : Choisi sa victime
                Console.Clear();
                Console.WriteLine("Lequel voullez-vous tuer ?");
                for (int i= 0; i < nbPlayer; i++)
                {
                    if (players[i].IsAlive && killer != players[i])
                    Console.WriteLine($"{i+1}. {players[i].Name}");
                }
                int choice = int.Parse(Console.ReadLine());
                killer.Kill(players[choice - 1]);
            } while (true);
            */

            Jeu.Play();
        }
    }
}