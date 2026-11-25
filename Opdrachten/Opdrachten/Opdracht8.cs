using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{

    class Player
    {
        private string _name;
        private int _level;
        private int _lives;

        public Player(string Name, int Level, int Lives)
        {
            _name = Name;
            _level = Level;
            _lives = Lives;
            Console.WriteLine($"Player {_name} has been created, Level: {_level}");
        }
        public void ShowStats()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{_name} is Level: {_level}");
            Console.WriteLine($"{_lives} lives left");
            Console.WriteLine("-------------------------------");
        }
    }
    public class Opdracht8
    {
        public void Start()
        {
            Player player1 = new Player("Speler1", 5, 3);
            Player player2 = new Player("Speler2", 10, 2);
            Player player3 = new Player("Speler3", 15, 3);

            List<Player> players = new List<Player> { player1, player2, player3 };
            Console.WriteLine(" ");
            foreach (Player plr in players)
            {
                plr.ShowStats();
            }
        }
    }
}
