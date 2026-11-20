using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{

    class Player
    {
        string name;
        int level;
        int lives;

        public Player(string Name, int Level, int Lives)
        {
            name = Name;
            level = Level;
            lives = Lives;
            Console.WriteLine($"Player {name} has been created, Level: {level}");
        }
        public void ShowStats()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{name} is Level: {level}");
            Console.WriteLine($"{lives} lives left");
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
