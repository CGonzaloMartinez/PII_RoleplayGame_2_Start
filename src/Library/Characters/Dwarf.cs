namespace RoleplayGame
{
    public class Dwarf : Character
    {
        public Axe Axe{get;set;}
        public Helmet Helmet{get;set;}
        public Shield Shield{get;set;}
        public override int Attack
        {
            get
            {
                return this.Axe.Attack;
            }
        }

        public override int Defense
        {
            get
            {
                return this.Helmet.Defense + this.Shield.Defense;
            }
        }
        public Dwarf(string name)
        : base(name)
        {
        }
    }
}