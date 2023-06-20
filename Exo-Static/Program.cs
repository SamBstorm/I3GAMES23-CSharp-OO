using Exo_Static.Models;

namespace Exo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equation.A = 1;
            Equation.B = 3;
            Equation.C = 2;

            Console.WriteLine($"L'équation est {Equation.A}x² + {Equation.B}x + {Equation.C}");
            //if (Equation.EstPossible())
            //    Console.WriteLine("est possible à résoudre!");
            //else Console.WriteLine("n'est pas résolvable...");

            if (Equation.Resoudre(out double? x1, out double? x2))
                Console.WriteLine($"est possible à résoudre! X1 vaut : {x1} & X2 vaut {x2}");
            else Console.WriteLine("n'est pas résolvable...");
        }
    }
}