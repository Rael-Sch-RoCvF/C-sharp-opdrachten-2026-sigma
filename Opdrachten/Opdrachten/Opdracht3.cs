using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht3
    {
        public void Start()
        {
            String[] weathers =
            {
                "Sunny",
                "Rainy",
                "Cloudy"
            };

            Console.WriteLine("What weather is the most accurate to yours currently?");
            for (int i = 0; i < weathers.Length; i++)
            {
                Console.WriteLine($"- {weathers[i]}");
            }
            String weather = Console.ReadLine();

            Console.WriteLine("What temperature is it?");
            String temp = Console.ReadLine();

            while (!int.TryParse(temp, out int t))
            {
                Console.WriteLine("Please enter a valid number for the temperature.");
                temp = Console.ReadLine();
            }
            
            int temperature = Convert.ToInt32(temp);


            if (temperature > 50)
            {
                Console.WriteLine("Dude it cannot be that hot but alright");
                Console.WriteLine("------------------");
            }

            switch (weather)
            {
                case "Sunny":
                    if (temperature > 20)
                    {
                        Console.WriteLine("That's some really nice weather, go out and have some fun!");
                    }
                    else
                    {
                        Console.WriteLine("That's still some nice weather!");
                    }
                    break;

                case "Rainy":
                    if (temperature > 20)
                    {
                        Console.WriteLine("That's some odd weather, go out to see if you can spot a rainbow! (do bring an umbrella)");
                    }
                    else
                    {
                        Console.WriteLine("That's still some chill weather, stay inside and chill out!");
                    }
                    break;

                case "Cloudy":
                    if (temperature > 20)
                    {
                        Console.WriteLine("That's not bad weather, I hope it doesn't start raining!");
                    }
                    else
                    {
                        Console.WriteLine("That's some depressing weather, just stay inside");
                    }
                    break;

                default:
                    Console.WriteLine("I do not recognize that weather, please try again.");
                    break;
            }


        }
    }
}
