namespace RoleplayGame
{
    public class Wizard: Character
    {
        public SpellsBook spellsBook {get;set;}
        public Staff staff           {get;set;}

        public Wizard(string name)
        : base (name)
        {
        }

        public override int Attack
        {
            get
            {
                return this.spellsBook.Attack + this.staff.Attack;
            }
        }

        public override int Defense
        {
            get
            {
                return this.spellsBook.Defense + this.staff.Defense;
            }
        }

    }
}