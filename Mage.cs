using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"Mage {name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public virtual int Attack(Rat e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name +  " approaches " + this.GetType() + " " + this.name+".");
            if (CanCastSpell())
            {
                Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                return spellPower;
            }
            else
            {
                return 0;
            }
        }

        public virtual int Attack(Giant e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (CanCastSpell())
            {
                Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                return spellPower;
            }
            else
            {
                return 0;
            }
        }

        public virtual int Attack(Ogre e)
        {
            Console.WriteLine(e.GetType() + " " + e.Name + " approaches " + this.GetType() + " " + this.name + ".");
            if (CanCastSpell())
            {
                Console.WriteLine(this.GetType() + " " + this.name + " casts a spell on " + e.GetType() + " " + e.Name + " causing " + spellPower + " damage.");
                return spellPower;
            }
            else
            {
                return 0;
            }
        }
    }
}