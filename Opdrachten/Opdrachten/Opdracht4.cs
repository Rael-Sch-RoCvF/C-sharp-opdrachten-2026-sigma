using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    public class Opdracht4
    {
        public void Start()
        {
            bool correct = false;
            int year = 0, month = 0, day = 0;


            while (!correct)
            {
                Console.WriteLine("What year were you born?");
                string sYear = Console.ReadLine();
                Console.WriteLine("What month were you born? (1-12)");
                string sMonth = Console.ReadLine();
                Console.WriteLine("What day were you born?");
                string sDay = Console.ReadLine();

                if (int.TryParse(sYear, out year) && int.TryParse(sMonth, out month) && int.TryParse(sDay, out day))
                {
                    year = Convert.ToInt32(sYear);
                    month = Convert.ToInt32(sMonth);
                    day = Convert.ToInt32(sDay);

                    bool valuesCorrect = !(day > 31 || day < 1) && !(month > 12 || month < 1);

                    Console.WriteLine(" ");
                    correct = valuesCorrect;
                    Console.WriteLine((correct ? "Age verified correctly" : "age doesn't match up, try again"));
                }
                else
                {
                    Console.WriteLine("One of the values was invalid, please try again");
                    correct = false;
                }
            }

            int age = DateTime.Today.Subtract(new DateTime(year, month, day)).Days / 365;
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine(" ");
            if (IsAnAdult(age))
            {
                Console.WriteLine("and you are allowed to vote");
                AgeTips(age);
            }
            else
            {
                Console.WriteLine("and you are NOT allowed to vote.");
            }

        }

        bool IsAnAdult(int age)
        {
            return (age > 18);
        }

        void AgeTips(int age)
        {
            if (age > 18 && age < 25)
            {
                Console.WriteLine("Extra tip: You should wear some casual clothes.");
            }
            else if (age >= 25 && age <= 40)
            {
                Console.WriteLine("Extra tip: You could wear some more business oriented clothes.");
            }
            else // above 40
            {
                Console.WriteLine("Extra tip: You could look good in formal outfits");
            }
        }

    }
}