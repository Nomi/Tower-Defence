using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }

        int IDefender.Attack(Rat e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (hasRat)
            {
                Console.WriteLine(this.GetType() + " " + this.name + " ignores " + e.GetType() + " " + e.Name);
                return 0;
            }
            else
            {
                Console.WriteLine(this.GetType() + " " + this.name + " catches " + e.GetType() + " " + e.Name);
                hasRat = true;
                return 99999999;        //assuming that max health is less than 99999999 then the enemy will die for sure.
            }
        }

        int IDefender.Attack(Giant e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            Console.WriteLine(this.GetType() + " " + this.name + " ignores " + e.GetType() + " " + e.Name+'.');
            return 0;
        }

        int IDefender.Attack(Ogre e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (!hasRat)
            {
                Console.WriteLine(this.GetType() + " " + this.name + " ignores " + e.GetType() + " " + e.Name + '.');
                return 0;
            }
            else
            {
                Console.WriteLine(this.GetType() + " " + this.name + " throws the rat it has on " + e.GetType() + " " + e.Name + " causing it to flee.");
                hasRat = false;
                return 99999999;        //assuming that max health is less than 99999999 then the enemy will die for sure.
            }
        }
    }
}