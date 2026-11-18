using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht1
    {
        public void Start()
        {
            Console.WriteLine("What is jouw naam?");
            string name = Console.ReadLine();
            Console.WriteLine("How oud ben jij?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hoi {name}, je bent {age} jaar oud!");
            Console.ReadLine();
        }
    }
}
