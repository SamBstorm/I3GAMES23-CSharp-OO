using ExoBonus_Props.TopSecret;

namespace ExoBonus_Props
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageSecret msg1 = new MessageSecret();
            //msg1.Receiver = "Sonia";                  //Pas fonctionnel car Private SET
            //msg1.Message = "Joyeux anniversaire!";    //Pas fonctionnel car Private SET
            //msg1.Sender = "Samuel";
            msg1.Write("Samuel", "Sonia", "Joyeux anniversaire!");
            MessageSecret msg2 = msg1.Answer("Merci beaucoup!");
            MessageSecret msg3 = msg2.Answer("Mais c'est tout naturel!");
        }
    }
}