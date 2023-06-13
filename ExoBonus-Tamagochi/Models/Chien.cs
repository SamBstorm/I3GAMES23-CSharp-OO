using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Tamagochi.Models
{
    internal class Chien : Animal
    {
        public void Promener()
        {
            if (EstVivant && Action > 1)
            {
                Bonheur += 5;
                Sante--;
                Faim--;
                Action -= 2;
            }
        }

        public override void Manger()
        {
            if (Action > 0 && EstVivant)
            {
                int choix;
                do
                {
                    Console.WriteLine(@"Veuillez choisir :
1. Croquettes
2. Os");
                    choix = int.Parse(Console.ReadLine());
                } while (choix != 1 && choix != 2);

                if (choix == 1)
                {
                    Faim += 2;
                    Bonheur += 2;
                }
                else
                {
                    Faim++;
                    Bonheur += 3;
                }
                Sante--;
                Action--;
            }
        }

        public override void Nettoyer()
        {
            if(Action > 1 && EstVivant)
            {
                base.Nettoyer();
                Action--;
            }
        }
    }
}
