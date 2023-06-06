using Demo_Index.Models;

namespace Demo_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classe = new ClassRoom();
            classe.Nom = "Unity 03";

            Student student_1 = new Student();
            student_1.Prenom = "Tonia";
            student_1.Nom = "Vetrano";

            //classe._students.Add(student_1);  //Inaccessible à cause du private (c'est Ok, cela protège la liste!)

            classe.Add(student_1);

            Student student_2 = new Student();
            student_2.Nom = "Khallouk";
            student_2.Prenom = "Hafsa";

            classe.Add(student_2);

            Student student_3 = new Student();
            student_3.Nom = "Azrirak";
            student_3.Prenom = "Btissam";

            classe[0] = student_3;

            student_2.Prenom = "Rukia";

            Student test = classe["Khallouk", "Hafsa"];

            if(test is null )
            {
                Console.WriteLine("Il n'y a pas de Hafsa Khallouk dans la classe");
            }
            else
            {
                Console.WriteLine("Nous l'avons trouvé!");
            }

            test = classe["Khallouk", "Rukia"];

            if (test is null)
            {
                Console.WriteLine("Il n'y a pas de Rukia Khallouk dans la classe");
            }
            else
            {
                Console.WriteLine("Nous l'avons trouvé!");
            }
        }
    }
}