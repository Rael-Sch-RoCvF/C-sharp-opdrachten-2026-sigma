using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht10
    {
        public void Start()
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            string[] worddata = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
                worddata[i] = word[i].ToString();
            }

            string reconstruct = "";
            for (int i = 0; i < worddata.Length; i++)
            {
                reconstruct += worddata[worddata.Length - 1 - i];
            }

            Console.WriteLine(reconstruct);
            Console.WriteLine("");

            if (word == reconstruct)
            {
                Console.WriteLine("het is een palindroom!");
            }
            else
            {
                Console.WriteLine("het is geen palindroom!");
            }

        }
    }
}
