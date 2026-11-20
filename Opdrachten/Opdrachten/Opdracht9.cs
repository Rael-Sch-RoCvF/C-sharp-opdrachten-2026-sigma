using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class Weapon
    {
        string name;
        int damage;
        string type;

        public Weapon(string Name, int Damage, string Type)
        {
            name = Name;
            damage = Damage;
            type = Type;
        }

        public void ShowStats()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Weapon: {name}");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine("-------------------------------");
        }
        public void UpgradeItem(int amount)
        {
            Console.WriteLine($"{name}'s damage increased by {amount}!");
            damage += amount;
        }

    }
    public class Opdracht9
    {
        public void Start()
        {
            Weapon weapon1 = new Weapon("Gouden prikker", 10, "Spear");
            Weapon weapon2 = new Weapon("Glock", 50, "Gun");
            Weapon weapon3 = new Weapon("Dagger", 20, "Shortsword");

            List<Weapon> weapons = new List<Weapon> { weapon1, weapon2, weapon3 };

            foreach (Weapon wpn in weapons)
            {
                wpn.ShowStats();
                wpn.UpgradeItem(5);
                wpn.ShowStats();
            }

        }
    }
}
