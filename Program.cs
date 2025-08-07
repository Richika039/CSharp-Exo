using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int niveau = 123;
            float xpPourcentage = 54.45f;
            bool estVivant = true;
            string nom = "Bob";
            niveau = niveau + 3 - 2;
            niveau = 4 * 3;
            niveau = 9 / 10;
            niveau = 123;
            int modulo = niveau % 2;
            Console.WriteLine("Nom : " + nom);
            Pause();
            Console.WriteLine("Est vivant : " + estVivant);
            Pause();
            Console.WriteLine("XP : " + xpPourcentage + "%");
            Pause();
            Console.WriteLine("Niveau : " + niveau);
            Pause();
            int c = Addition(niveau, modulo);
            Console.WriteLine("Niveau + Modulo : " + c);
            Pause();
            Console.WriteLine("Niveau modulo 2 : " + modulo);
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }

        private static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
