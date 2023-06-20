using Demo_Static.Models;

namespace Demo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordinateur.RouterIP = "192.168.0.1";
            Ordinateur.ShowInfo();
            
            Ordinateur pc_1 = new Ordinateur();
            pc_1.NbRam = 4096;
            pc_1.CPUMhz = 2664;
            pc_1.GPUModel = "Nvidia";

            Ordinateur pc_2 = new Ordinateur();
            pc_2.NbRam = 8192;
            pc_2.CPUMhz = 2664;
            pc_2.GPUModel = "AMD";
        }
    }
}