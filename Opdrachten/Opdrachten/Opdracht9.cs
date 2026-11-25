using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class Weapon
    {
        private string _name;
        private int _damage;
        private string _type;

        public Weapon(string Name, int Damage, string Type)
        {
            _name = Name;
            _damage = Damage;
            _type = Type;
        }

        public void ShowStats()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Weapon: {_name}");
            Console.WriteLine($"Damage: {_damage}");
            Console.WriteLine($"Type: {_type}");
            Console.WriteLine("-------------------------------");
        }
        public void UpgradeItem(int amount)
        {
            Console.WriteLine($"{_name}'s damage increased by {amount}!");
            _damage += amount;
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
