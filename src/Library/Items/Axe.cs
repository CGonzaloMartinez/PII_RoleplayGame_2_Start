namespace RoleplayGame
{
    public class Axe : IAttackItem
    {
        public int Attack
        {
            get
            {
                return 25;
            }
            set
            {
                if(value >= 0)
                {
                    this.Attack = value;
                }
                else
                {
                    this.Attack = 0;
                }
            }
        }
    }
}