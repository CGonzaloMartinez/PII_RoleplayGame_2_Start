using System.Collections.Generic;


namespace RoleplayGame
{
    public abstract class Character
    {
        private int health;

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

        private int attack;
        public int Attack
        {
            get
            {
                return this.attack;
            }

            set
            {
                if (value >= 0)
                {
                    this.attack = value;
                }
                else
                {
                    this.attack = 0;
                }
            }
        }
        
        public string Name;

        private int totalDefense;

        public int TotalDefense
        {
            get
            {
                return this.totalDefense;
            }

            set
            {
                if (value >= 0)
                {
                    this.totalDefense = value;
                }
                else
                {
                    this.totalDefense = 0;
                }
            }
        }
        

        public Character(string name)
        {
            this.Name = name;
        }

        public List<IItem> items;
        

        public void AttackValue()
        {
           int totalAttack = 0;

          foreach (IItem item in items)
          {
            totalAttack += item.Attack;
          }  

            this.Attack = totalAttack;
        }

        public void DefenseValue()
        {
            int totalDefense = 0;
            foreach (IItem item in items)
            {
                totalDefense += item.Defense;
            }

            this.TotalDefense = totalDefense;
        }


        public void ReceiveAttack(int power)
        {
            if (this.TotalDefense < power)
            {
                this.Health -= power - this.totalDefense;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }



}
