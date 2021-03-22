using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }
        public virtual int Attack(Rat e)
        {
            if (rng.NextDouble() < e.Speed / 100)
            {
                Console.WriteLine(this.GetType() + " "  + this.name + " attacks " + e.GetType() + " "  + e.Name + "but misses.");
                return 0;
            }
            else
            {
                Console.WriteLine(this.GetType() + " "  + this.name + " attacks " + e.GetType() + " "  + e.Name + " causing " + strength + " damage.");
                return strength;
            }
        }

        public virtual int Attack(Ogre e)
        {
            Console.WriteLine(this.GetType() + " "  + this.name + " attacks " + e.GetType() + " "  + e.Name + " causing " + strength + " damage.");
            return strength;
        }

        public virtual int Attack(Giant e)
        {
            Console.WriteLine(this.GetType() + " "  + this.name + " attacks " + e.GetType() + " "  + e.Name + " causing " + strength + " damage.");
            return strength;
        }
    }
}