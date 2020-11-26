using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Worksheet5_Question3
{
    public abstract class Character : IAttack
    {
        public abstract void Attack(Character character);

        //Health, mana and damage

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        protected Character(int h, int m, int d)
        {
            Health = h;
            Mana = m;
            Damage = d;
        }
    }
}
