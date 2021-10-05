using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> foot = new Dictionary<char, List<string>>();
            foot['a'] = new List<string> { "Allez", "Racing", "Strasbourg" };
            foot['b'] = new List<string> { "Allez", "Les", "Bleus" };
            foot['c'] = new List<string> { "Au", "chiotte", "OM" };

            ResultDictionary(foot);

            Console.WriteLine("-------------------\n");

            foot.Remove('c');

            ResultDictionary(foot);

            Console.ReadLine();

        }

        static void ResultDictionary(Dictionary<char, List<string>> dictionary)
        {
            Console.WriteLine(" Mon dictionnaire contient: \n");
                foreach (var mots in dictionary)
            {
                Console.Write($" Lettre: {mots.Key} => Valeurs: \n");
                    mots.Value.ForEach(Console.WriteLine);
                Console.WriteLine();
            }
        }
    }
}
