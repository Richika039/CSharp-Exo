using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Écrivez votre nom :");
            string n = Console.ReadLine();

            Console.WriteLine("Écrivez votre âge :");
            string a = Console.ReadLine();

            Console.WriteLine(string.Format("Vous vous appelez : {0}, vous avez : {1} ans, confirmez-vous cette information ?", n, a));

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
