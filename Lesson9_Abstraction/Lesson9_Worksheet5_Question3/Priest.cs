using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Worksheet5_Question3
{
    class Priest : Character, IHeal
    {
        public Priest() : base(125, 200, 100)
        {

        }

        public override void Attack(Character character)
        {
            this.Mana -= Mana;
            character.Health -= Damage;
            this.Health += ((10 / 100) * Damage);
        }

        public void Heal(Character character)
        {
            this.Mana -= 100;
            character.Health += 150;
        }
    }
}
