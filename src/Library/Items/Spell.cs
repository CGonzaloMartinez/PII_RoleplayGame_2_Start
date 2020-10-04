namespace RoleplayGame
{
    public class Spell : IItem, IAttackItem, IDefenseItem
    {
        public int Attack
        {
            get
            {
                return 70;
            }
        }

        public int Defense
        {
            get
            {
                return 70;
            }
        }
    }
}