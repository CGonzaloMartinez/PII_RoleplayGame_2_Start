namespace RoleplayGame
{
    public class Helmet : IDefenseItem
    {
        public int Defense
        {
            get
            {
                return 18;
            }
            set
            {
                if(value >= 0)
                {
                    this.Defense = value;
                }
                else
                {
                    this.Defense = 0;
                }
            }
        }
    }
}