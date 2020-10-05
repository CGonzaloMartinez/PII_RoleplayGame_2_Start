namespace RoleplayGame
{
    public class Archer : Character
    {
        public Bow Bow{get;set;}
        public Armor Armor{get;set;}

        public override int Attack
        {
            get
            {
                return this.Bow.Attack;
            }
        }

        public override int Defense
        {
            get
            {
                return this.Armor.Defense;
            }
        }

        public Archer(string name)
        : base(name)
        {

        }
    }
}