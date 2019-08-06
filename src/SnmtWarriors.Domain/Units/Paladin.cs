using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units
{
    public class Paladin : UnitWithAttackBase, IWithMana, IWithArmor, IWithPassiveSkill
    {
        public Paladin(
            string id,
            string name,
            int healthPoints,
            int manaPoints,
            IDamage damage,
            IArmor armor,
            IPassiveSkill passiveSkill)
            : base(id, name, healthPoints, damage)
        {
            AttackHandlers.Add(passiveSkill);
            AttackModule.AddAttackProducer(passiveSkill);
            
            ArmorPoints = armor.ArmorPoints;
            PassiveSkill = passiveSkill;
            ManaPoints = manaPoints;
        }
        
        public int ManaPoints { get; }
        
        public int ArmorPoints { get; }
        
        public IPassiveSkill PassiveSkill { get; }
    }
}