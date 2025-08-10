using System;
namespace ConsoleApp1
{
    class Program
    {
       private static void Main(string[] args)
        {
            double[] solde = new double[6];
            solde[0] = 234.56;
            solde[1] = 123.45;
            //int[] notes = {12, 14, 16, 18, 20};
            //int[] notes = new int[6] { 12, 14, 16, 18, 20 };
            int[] notes = { 12, 14, 16, 18, 20, 19 };
            Console.WriteLine("taille du tableau " + notes.Length);
            Console.WriteLine("la 3e notes est :" + notes[4]);
            Console.WriteLine("la dernière note est :" + notes[notes.Length - 1]);
            string[,] siblings = new string[2, 2]
            {
                {"Alice", "Bob"},
                {"Charlie", "Diana"}
            };
            Console.WriteLine(siblings[0,0]);
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
