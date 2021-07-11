using Utilities.Contract;

namespace Game.Scripts.Domain
{
    public class Character
    {
        public int CurrentHp { get; private set; }

        public Character(int initHp)
        {
            CurrentHp = initHp;
        }

        public void DealDamage(int damage)
        {
            Contract.Require(damage>=0,"damage is negetive number");
            CurrentHp -= damage;
        }
    }
}