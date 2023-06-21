using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Dispose.Models
{
    internal class DisposableObject : IDisposable
    {
        public DisposableObject() {
            Console.WriteLine("Je suis un objet qui implémente IDisposable.");
        }
        public void Dispose()
        {
            Console.WriteLine("Le garbage collector n'est pas encore passé, ce n'est rien, je sais ce que je dois faire. Adieu!");
        }
    }
}
