using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Wicher_Road_of_Rodents.Mechanics
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public Character(string name, int health, int strength, int agility, int intelligence)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
        }

        public void Attack(Character target)
        {
            int damage = this.Strength - target.Agility;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{this.Name} attacks {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{this.Name} attacks {target.Name} but it has no effect.");
            }
        }

        public void Heal(int amount)
        {
            this.Health += amount;
            Console.WriteLine($"{this.Name} heals for {amount} health points.");
        }
    }
}
