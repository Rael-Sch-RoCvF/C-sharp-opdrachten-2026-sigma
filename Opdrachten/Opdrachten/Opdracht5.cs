using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht5
    {
        public void Start()
        {
            Console.WriteLine("Which times table do you want to view?");
            int table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To which multiplication do you want it to run?");
            int mult = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= mult; i++)
            {
                Console.WriteLine($"{table} x {i} = {table * i}");
            }
        }

        public void Bronze()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Silver()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"7 x {i} = {7 * i}");
            }
        }

    }
}
