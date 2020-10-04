namespace RoleplayGame
{
    public class Dwarf : Character
    {
        private int health = 100;
        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public Dwarf(string name)
        : base(name)
        {
            this.Health = 100;
            this.items.Add(Axe);
            this.items.Add(Shield);
            this.items.Add(Helmet);
        }
    }
}