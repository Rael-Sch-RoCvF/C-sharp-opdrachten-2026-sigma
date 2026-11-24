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
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            word = word.ToLower();
            char[] worddata = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
                worddata[i] = word[i];
            }

            string reconstruct = "";
            Array.Reverse(worddata);

            for (int i = 0; i < worddata.Length; i++)
            {
                if (i == 0)
                {
                    reconstruct += char.ToUpper(worddata[i]);
                }
                else
                {
                    reconstruct += worddata[i];
                }
                
            }

            Console.WriteLine(reconstruct);
            Console.WriteLine("");

            if (word.ToLower() == reconstruct.ToLower())
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
