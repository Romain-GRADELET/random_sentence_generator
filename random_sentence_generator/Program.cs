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

            const int NB_PHRASES = 10;

            for (int i = 0; i < NB_PHRASES; i++) 
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);

                var sentence = sujet + " " + verbe + " " + complement;

                sentence = sentence.Replace("à le", "au");

                Console.WriteLine(sentence);
            }

           

        }
    }
}