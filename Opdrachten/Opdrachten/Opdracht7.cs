using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht7
    {
        public void Start()
        {
            Random rnd = new Random();
            Console.WriteLine("How many rolls?");
            String testmax = Console.ReadLine();
            float[] nums = new float[6];

            while (!int.TryParse(testmax, out int Imax))
            {
                Console.WriteLine("Please enter a valid number");
                testmax = Console.ReadLine();
            }

            int max = Convert.ToInt32(testmax);

            for (int i = 0; i < max; i++)
            {
                int number = rnd.Next(0, 6);
                nums[number]++;
            }

            float[] highest = {0, 0};

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > highest[1])
                {
                    highest[0] = i + 1;
                    highest[1] = nums[i];
                }

                double perc = nums[i] / max * 100;
                Console.WriteLine($"{i + 1}: {nums[i]} | " + $"{perc:F1}%");
            }

            Console.WriteLine($"Highest: {highest[0]} (rolled {highest[1]} times)");

        }
    }
}
