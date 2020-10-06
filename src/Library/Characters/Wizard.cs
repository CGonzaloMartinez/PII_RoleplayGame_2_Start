namespace RoleplayGame
{
    public class Wizard: Character
    {
        public SpellsBook SpellsBook {get;set;}
        public Staff Staff           {get;set;}

        public Wizard(string name)
        : base (name)
        {
        }

        public override int Attack
        {
            get
            {
                return this.SpellsBook.Attack + this.Staff.Attack;
            }
        }

        public override int Defense
        {
            get
            {
                return this.SpellsBook.Defense + this.Staff.Defense;
            }
        }

    }
}