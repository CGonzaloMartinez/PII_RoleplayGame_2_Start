namespace RoleplayGame
{
    public class Staff : IItem, IAttackItem, IDefenseItem
    {
        public int Attack
        {
            get
            {
                return 100;
            } 
        }

        public int Defense
        {
            get
            {
                return 100;
            }
        }
    }
}