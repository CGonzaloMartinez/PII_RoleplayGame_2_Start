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
        public abstract int Attack{get;}

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
        public abstract int Defense{get;}

        public Character(string name)
        {
            this.Name = name;
        }

        public void ReceiveAttack(int power)
        {
            if (this.Defense < power)
            {
                this.Health -= power - this.Defense;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }



}
