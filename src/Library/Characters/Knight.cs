namespace RoleplayGame
{
    public class Knight : Character
    {
        public Greatsword Greatsword{get;set;}
        public Helmet Helmet{get;set;}
        public HeavyArmor HeavyArmor{get;set;}

        public override int Attack
        {
            get
            {
                return this.Greatsword.Attack;
            }
        }

        public override int Defense
        {
            get
            {
                return this.Helmet.Defense + this.HeavyArmor.Defense;
            }
        }
        public Knight(string name) : base(name)
        {
        }
    }
}