using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units
{
    public class ArcherCaptain : Archer, IWithArmor
    {
        public ArcherCaptain(
            string id,
            string name,
            int healthPoints,
            int manaPoints,
            IDamage damage,
            IActiveSkill activeSkill,
            IArmor armor) 
            : base(id, name, healthPoints, manaPoints, damage, activeSkill)
        {
            AttackHandlers.Add(armor);

            ArmorPoints = armor.ArmorPoints;
        }

        public int ArmorPoints { get; }
    }
}