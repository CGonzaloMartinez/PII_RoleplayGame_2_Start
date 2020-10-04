namespace RoleplayGame
{
    public class Shield : IDefenseItem
    {
        public int Defense
        {
            get
            {
                return 14;
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