using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte age = 23;
            // float f = 0.0025f;
            // decimal d = 0.025m;
            // string texte = "blablabla";
            // texte = texte + " totototot" + age.ToString() + "" + f;
            Console.WriteLine("Écrivez votre nom :");
            string n = Console.ReadLine();

            Console.WriteLine("Écrivez votre âge :");
            string a = Console.ReadLine();
            a = a + 1;

            Console.WriteLine(string.Format("Vous vous appelez : {0}, vous avez : {1} ans, confirmez-vous cette information ?", n, a));
            //Console.WriteLine("Vous vous appelez " + s + ", confirmez vous cette information ?");

            // Affiche le texte final
            //Console.WriteLine("Texte final : " + texte);

            // Appel de la pause
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
