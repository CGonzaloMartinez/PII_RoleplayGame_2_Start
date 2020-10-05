using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public abstract class Character
    {
        private int health = 100;

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value >= 0)
                {
                    this.health = value;
                }
                else
                {
                    this.health = 0;
                }
            }
        }
        public int Attack
        {
            get
            {
                return this.DefenseValue();
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        public int TotalDefense
        {
            get
            {
                return this.DefenseValue();
            }
        }
        

        public Character(string name)
        {
            this.Name = name;
        }

        public List<IItem> items;
        

        private int AttackValue()
        {
           int totalAttack = 0;

          foreach (IAttackItem item in items)
          {
            totalAttack += item.Attack;
          }

            return totalAttack;
        }

        private int DefenseValue()
        {
            int totalDefense = 0;
            foreach (IDefenseItem item in items)
            {
                totalDefense += item.Defense;
            }

            return totalDefense;
        }


        public void ReceiveAttack(int power)
        {
            if (this.TotalDefense < power)
            {
                this.Health -= power - this.TotalDefense;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }



}
