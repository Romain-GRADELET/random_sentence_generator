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

            const int NB_PHRASES = 100;
            var phrasesUniques = new List<string>();
            int doublons = 0;

            while (phrasesUniques.Count < NB_PHRASES )
            {

                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);

                var phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");

                if (!phrasesUniques.Contains(phrase)) 
                {
                    phrasesUniques.Add(phrase);
                }
                else
                {
                    doublons++;
                }
            }

            foreach (var phrase in phrasesUniques)
            {
                Console.WriteLine(phrase);
            }

            Console.WriteLine();
            Console.WriteLine("Nombre de phrase unique générée : " + phrasesUniques.Count);
            Console.WriteLine("Nombre de doublon évité : " + doublons);


        }
    }
}