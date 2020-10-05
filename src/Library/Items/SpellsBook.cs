using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IAttackItem, IDefenseItem

    {   public Spell[] Spells { get; set; }
        
        public int Attack
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.Attack;
                }
                return value;
            }
        }

        public int Defense
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.Defense;
                }
                return value;
            }
        }

    }
}