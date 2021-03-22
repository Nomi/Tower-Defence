using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }
        public override int Attack(Rat e)
        {
            if(arrows>0)
            {
                arrows--;
                if (rng.NextDouble() < e.Speed / 100)
                {
                    return 0;
                }
                else
                {
                    Console.WriteLine(this.GetType() + " attacks " + e.GetType() + " causing " + strength + " damage.");
                    return strength;
                }
            }
            return 0;
        }

        public override int Attack(Ogre e)
        {
            if(arrows>0)
            {
                Console.WriteLine(this.GetType() + " attacks " + e.GetType() + " causing " + strength + " damage.");
                return strength;
            }
            return 0;
        }

        public override int Attack(Giant e)
        {
            if(arrows>=2)
            {
                arrows -= 2;
                Console.WriteLine(this.GetType() + " attacks " + e.GetType() + " causing " + strength + " damage.");    //I'm not using 2*strength because I'm assuming Giant takes less/half damage from single arrows?
                return strength;        //I'm not using 2*strength because I'm assuming Giant takes less/half damage from single arrow?
            }
            return 0;
        }
    }
}