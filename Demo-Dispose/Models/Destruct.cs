using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Dispose.Models
{
    internal class Destruct
    {
        //Constructeur
        public Destruct()
        {
            Console.WriteLine("Je suis un objet qui utilise un destructeur.");
        }

        //Destructeur
        ~Destruct()
        {
            Console.WriteLine("Le garbage collector est passé! Adieu monde cruel!");
        }
    }
}
