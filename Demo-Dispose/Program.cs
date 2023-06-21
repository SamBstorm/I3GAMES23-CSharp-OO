using Demo_Dispose.Models;

namespace Demo_Dispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Destruct destructeur = new Destruct();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            using (DisposableObject disposable = new DisposableObject())
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}