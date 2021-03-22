using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }
        public override int Attack(Rat e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (CanCastSpell())
            {

                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a CRITICAL spell on " + e.GetType() + " " + e.Name + " killing it immediately.");
                    return 99999999;        //assuming that max health is less than 99999999 then the enemy will die for sure.
                }
                else
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                    return spellPower;
                }
            }
            else
            {
                return 0;
            }
        }

        public override int Attack(Giant e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (CanCastSpell())
            {

                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a CRITICAL spell on " + e.GetType() + " " + e.Name + " killing it immediately.");
                    return 99999999;        //assuming that max health is less than 99999999 then the enemy will die for sure.
                }
                else
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                    return spellPower;
                }
            }
            else
            {
                return 0;
            }
        }

        public override int Attack(Ogre e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (CanCastSpell())
            {

                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a CRITICAL spell on " + e.GetType() + " " + e.Name + " killing it immediately.");
                    return 99999999;        //assuming that max health is less than 99999999 then the enemy will die for sure.
                }
                else
                {
                    Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                    return spellPower;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}