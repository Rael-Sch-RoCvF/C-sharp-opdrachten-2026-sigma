using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht6
    {
        public void Start()
        {
            int guesses = 0;
            Console.WriteLine("What do you want to be the max number?");
            int Max = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int number = rnd.Next(1, Max);

            Console.WriteLine($"I have picked a number between 1 and {Max}, can you guess it?");

            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if (guess == number)
                {
                    Console.WriteLine("yay you guessed it good job");
                    Console.WriteLine($"It took you {guesses} guesses!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("The number is higher than your current guess");
                }
                else if (guess > number)
                {
                    Console.WriteLine("The number is lower than your current guess");
                }
            }

        }
    }
}
