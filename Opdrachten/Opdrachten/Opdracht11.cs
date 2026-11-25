using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class Questions
    {
        private int _points = 0;
        private int _min = 0;
        private int _max = 0;
        private int _type = 0;

        public Questions(int min, int max, int type)
        {
            _min = min;
            _max = max;
            _type = type;
        }
        public void Create()
        {
            Random rnd = new Random();
            Random nums = new Random();
            int questType = (_type == 0) ? rnd.Next(1, 5) : _type;
            int[] questionnums = { nums.Next(_min, _max), nums.Next(_min, _max) };
            int answer = 0;

            switch (questType)
            {
                case 1: // plus
                    Console.WriteLine($"{questionnums[0]} + {questionnums[1]} = ");
                    answer = questionnums[0] + questionnums[1];
                    break;

                case 2: // minus
                    Console.WriteLine($"{questionnums[0]} - {questionnums[1]} = ");
                    answer = questionnums[0] - questionnums[1];
                    break;

                case 3: // times
                    Console.WriteLine($"{questionnums[0]} * {questionnums[1]} = ");
                    answer = questionnums[0] * questionnums[1];
                    break;

                case 4: // divide
                    Console.WriteLine($"{questionnums[0]} / {questionnums[1]} = ");
                    answer = questionnums[0] / questionnums[1];
                    break;

            }

            bool process = true;
            int reply = 0;

            while (process)
            {
                string testreply = Console.ReadLine();
                if (int.TryParse(testreply, out int res))
                {
                    reply = Convert.ToInt32(testreply);
                    process = false;
                }
            }

            if (GetAnswer(answer, reply))
            {
                _points++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine($"That is incorrect, the answer was {answer}");
            }

        }

        public int GetPoints()
        {
            return _points;
        }

        public bool GetAnswer(int answer, int reply)
        {
            return reply == answer;
        }
    }
    public class Opdracht11
    {
        public void Start()
        {
            Console.WriteLine("Choose the questions type: ");
            Console.WriteLine("0: random | 1: + | 2: - | 3: * | 4: /");
            string testUserType = "";
            while (!int.TryParse(testUserType, out int a))
            {
                testUserType = Console.ReadLine();
            }

            int userType = Convert.ToInt32(testUserType);
            Questions program = new Questions(0, 11, userType);
            int loops = 5;
            for (int i = 0; i < loops; i++)
            {
                program.Create();
            }

            int points = program.GetPoints();
            Console.WriteLine("---------------------------");
            if (points < 0.5 * loops)
            {
                Console.WriteLine("you failed");
            }
            else
            {
                Console.WriteLine("Good job you can do basic math");
            }

            Console.WriteLine($"{points}/{loops} correct");
        }


       
        
    }
}
