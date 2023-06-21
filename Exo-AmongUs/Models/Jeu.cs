using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_AmongUs.Models
{
    internal static class Jeu
    {
        private static Random _rng = new Random();
        private static List<IJoueur> _players;
        private static List<IJoueur> _rejecteds = new List<IJoueur>();
        private static List<IJoueur> _deads = new List<IJoueur>();
        private static ITueur _killer;

        public static void Play()
        {
            Console.Clear();
            Console.WriteLine("Among US Console edition!");
            int nbPlayer = ConsoleReadInt("Combien de joueur ? (3 à 20)", 3, 20);
            SetPlayers(nbPlayer);
            SetAKiller();
            Console.WriteLine($"{_killer.Name} vous êtes le tueur!");
            Console.ReadLine();
            do
            {
                //Tueur
                IJoueur choosen = ChooseVictim();
                _killer.Kill(choosen);
                _deads.Add(choosen);
                _players.Remove(choosen);
                LogEvent($"{choosen.Name} a été tué!");
                //Vote
                Dictionary<string, int> votes = SetVoteSession();
                IJoueur rejected = HigherVote(votes);
                _rejecteds.Add(rejected);
                _players.Remove(rejected);
                LogEvent($"{rejected.Name} a été écarté!");
                if(rejected != _killer)
                    LogEvent("Le tueur court toujours");
            } while (_players.Contains(_killer) && _players.Count > 2);
            if (_players.Contains(_killer)) LogEvent($"GAME OVER...\n{_killer.Name} était le tueur...");
            else LogEvent($"Féliciation!\n{_killer.Name} était bien le tueur!");
        }

        /// <summary>
        /// LogEvent est une fonction permettant l'affichage en console d'un message, et se termine lorsque l'on appuie sur 'Enter'
        /// </summary>
        /// <param name="message">Correspond au message affiché en console</param>
        private static void LogEvent(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadLine();
        }

        /// <summary>
        /// Permet d'afficher la liste des potentiels victimes du Tueur.
        /// Et retourne un IJoueur correspondant.
        /// </summary>
        /// <returns>IJoueur de notre victime.</returns>
        private static IJoueur ChooseVictim()
        {
            IJoueur choosen;
            do { 
                Console.Clear();
                Console.WriteLine("Lequel voullez-vous tuer ?");
                ListCandidate(false);
                int choice = ConsoleReadInt("Donner un numéro :", 1 , _players.Count);
                choosen = _players[choice - 1];
            } while(choosen == _killer);
            return choosen;
        }

        private static void SetPlayers(int nbPlayer)
        {
            _players = new List<IJoueur>();
            for (int i = 0; i < nbPlayer; i++)
            {
                Console.Clear();
                Console.WriteLine($"Indiquez votre nom Joueur {i + 1}:");
                string name = Console.ReadLine();
                _players.Add(new Personnage() { Name = name });
            }
        }

        private static void SetAKiller()
        {
            _killer = (Personnage)_players[_rng.Next(_players.Count)];
        }

        private static Dictionary<string, int> SetVoteSession()
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            foreach (IJoueur currentPlayer in _players)
            {
                string name = null;
                Console.Clear();
                LogEvent($"A votre tour de voter {currentPlayer.Name} !");
                Console.WriteLine("Qui allez-vous éliminer ?");
                ListCandidate();
                int choice = ConsoleReadInt("Veuillez entrer le numéro du joueur :", 1, _players.Count);
                name = currentPlayer.Vote(_players[choice - 1]);
                if (name != null)
                {
                    if (votes.ContainsKey(name)) votes[name]++;
                    else votes.Add(name, 1);
                }

            }
            return votes;
        }

        private static void ListCandidate(bool showKiller = true)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (!showKiller && _players[i] != _killer && _players[i].IsAlive)
                    Console.WriteLine($"{i + 1}. {_players[i].Name}");
                else if (showKiller && _players[i].IsAlive)
                    Console.WriteLine($"{i + 1}. {_players[i].Name}");
            }
        }

        private static IJoueur HigherVote(Dictionary<string, int> votes)
        {
            string choosenOne = null;
            int maxVote = 0;
            bool isFirst = true;
            foreach (KeyValuePair<string, int> kvp in votes)
            {
                if (isFirst)
                {
                    choosenOne = kvp.Key;
                    maxVote = kvp.Value;
                    isFirst = false;
                }
                else
                {
                    if (kvp.Value > maxVote)
                    {
                        choosenOne = kvp.Key;
                        maxVote = kvp.Value;
                    }
                }
            }
            foreach (IJoueur player in _players)
            {
                if (player.Name == choosenOne) return player;
            }
            return null;

            /* Tout le code peut être remplacé par des fonctions LinQ
             * 
            string name = votes.FirstOrDefault(kvp => kvp.Value == votes.Values.Max()).Key;
            return _players.SingleOrDefault(p => p.Name == name);
            */
        }

        private static int ConsoleReadInt(string message, int min = 0, int max = 20)
        {
            int result;
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result) || (result < min || result > max));
            return result;
        }
    }
}
