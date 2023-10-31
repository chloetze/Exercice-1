using System;


namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclarations et initialisations
            string prenom = "Alain";
            string nom = "DUPONT";
            int age = 19;

            // saisie des 3 informations
            Console.Write("Alain");
            prenom = Console.ReadLine();
            Console.Write("DUPONT");
            nom = Console.ReadLine();
            Console.Write("19");
            age = int.Parse(Console.ReadLine());
           
            // afficahge personnalisé
            Console.WriteLine("Bonjour" + prenom + " " + nom + ", vous avez " + age + "ans.");
            Console.ReadLine();

        }
    }
}
