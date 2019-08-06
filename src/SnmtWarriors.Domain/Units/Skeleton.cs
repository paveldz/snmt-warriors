using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units
{
    public class Skeleton : UnitWithAttackBase, IWithArmor, IWithPassiveSkill
    {
        public Skeleton(
            string id,
            string name,
            int healthPoints,
            IDamage damage,
            IArmor armor,
            IPassiveSkill passiveSkill) 
            : base(id, name, healthPoints, damage)
        {
            AttackHandlers.Add(passiveSkill);
            AttackModule.AddAttackProducer(passiveSkill);
            
            ArmorPoints = armor.ArmorPoints;
            PassiveSkill = passiveSkill;
        }
        
        public int ArmorPoints { get; }
        public IPassiveSkill PassiveSkill { get; }
    }
}