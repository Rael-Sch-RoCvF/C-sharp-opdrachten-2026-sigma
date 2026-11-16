using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht2
    {
        public String[] rooms =
        {
            "Kitchen",
            "Living Room",
            "Bathroom",
            "Bedroom",
            "Hallway"
        };

        void Start()
        {
            String[] Interaction =
            {
            "Toilet",
            "Upstairs",
            "Kitchen"
            };

            void InteractionPrompts()
            {
                for (int i = 0; i < Interaction.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {Interaction[i]}");
                }

            }

            void Main(string[] args)
            {
                Console.WriteLine("Choose where you want to go: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    default:

                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
