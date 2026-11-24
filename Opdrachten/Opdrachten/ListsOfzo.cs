using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class ListsOfzo
    {
        private List<string> items = new List<string>();
        private List<int> ints = new List<int>();
        private List<bool> bools = new List<bool>();
        public void Start()
        {
            items.Clear();
            items.Add("Key");
            items.Add("Bottle");
            items.Add("rock");

            items.Reverse();

            Console.WriteLine("");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            ints.Clear();
            ints.Add(5);
            ints.Add(2);
            ints.Add(19);

            ints.Reverse();

            Console.WriteLine("");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            bools.Clear();
            bools.Add(true);
            bools.Add(true);
            bools.Add(false);

            bools.Reverse();

            Console.WriteLine("");
            foreach (bool i in bools)
            {
                Console.WriteLine(i);
            }




        }
    }
}
