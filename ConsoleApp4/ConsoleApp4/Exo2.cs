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

            // mimi
            // 0123
            // m imi
            Console.WriteLine("Écrivez votre nom :");
            string n = Console.ReadLine();
            n = n.Replace('t', 'm'); // Remplace tous les 't' par des 'm'
            //toLower prend les majuscule en minuscule
            //toUpper prend les minuscule et met en majuscule
            n = n.Insert(2, " ");
            //n = n.Remove(4, 2); 
            Console.WriteLine("Écrivez votre âge :");
            string a = Console.ReadLine();
            decimal age;
            bool réussite = decimal.TryParse(a, out age); // Conversion directe en decimal
            Console.WriteLine("Conversion réussite :" + réussite);
            age = age + 3;
            Console.WriteLine(string.Format("Vous vous appelez : {0}, vous avez : {1} ans, confirmez-vous cette information ?", n, age));
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
