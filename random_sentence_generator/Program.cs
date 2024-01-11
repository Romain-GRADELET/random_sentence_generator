using System;

namespace random_sentence_generator
{
    class Program
    {
        static string ObtenirElementAleatoire(string[] t) 
        {
            Random r = new Random();
            int index = r.Next(t.Length);
            return t[index];
        }

        static void Main(string[] args)
        {
            // Généréer des phrase sujet -> verbe -> complément
            var sujets = new string[]
            {
                "Un lapin",
                "Un homme",
                "Une femme",
                "Un chat",
                "Un chien",
                "Une tortue",
                "Un enfant",
                "Un magicien",
                "un cheval",
            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "regarde",
                "néttoie",
                "avale",
                "attrape",
                "marche",
                "détruit",
                "s'accroche à"
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "le ciel",
                "une piscine",
                "un gateau",
                "un crapaud",
                "une carte",
            };

            for (int i = 0; i < 10; i++) 
            {
                string sujet = ObtenirElementAleatoire(sujets);
                string verbe = ObtenirElementAleatoire(verbes);
                string complement = ObtenirElementAleatoire(complements);

                Console.WriteLine(sujet + " " + verbe + " " + complement);
            }

           

        }
    }
}