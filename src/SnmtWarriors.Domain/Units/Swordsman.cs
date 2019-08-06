using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units
{
    public class Swordsman : UnitWithAttackBase, IWithArmor
    {
        public Swordsman(
            string id,
            string name,
            int healthPoints,
            IDamage damage,
            IArmor armor) 
            : base(id, name, healthPoints, damage)
        {
            AttackHandlers.Add(armor);
            ArmorPoints = armor.ArmorPoints;
        }

        public int ArmorPoints { get; }
    }
}