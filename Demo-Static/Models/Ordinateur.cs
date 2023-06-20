using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static.Models
{
    internal class Ordinateur
    {
        public static string RouterIP { get; set; }
        public int NbRam { get; set; }
        public int CPUMhz { get; set; }
        public string GPUModel { get; set; }

        public static void ShowInfo()
        {
            Console.WriteLine($"L'ip du router est :{RouterIP}");
            //CPUMhz n'est pas static donc pas accessible pour les méthodes static
            //Console.WriteLine($"Le CPU est :{CPUMhz}");
        }
    }
}
