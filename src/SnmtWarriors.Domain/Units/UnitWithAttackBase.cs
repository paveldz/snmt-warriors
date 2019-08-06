using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;
using SnmtWarriors.Domain.Units.Modules.Impl;

namespace SnmtWarriors.Domain.Units
{
    public abstract class UnitWithAttackBase : UnitBase, ICanAttack, IWithDamage
    {
        protected readonly IMultipleAttackProducer AttackModule;
        
        protected UnitWithAttackBase(
            string id,
            string name,
            int healthPoints,
            IDamage damage) 
            : base(id, name, healthPoints)
        {
            AttackModule = new DefaultAttackModule(damage);
            Damage = damage.DamageRange;
        }
        
        public IDamageRange Damage { get; }

        public void Attack(UnitBase unit)
        {
            IAttack attack = AttackModule.ProduceAttack(DefaultAttack.CreateZero(unit.Id));
            unit.TakeAttack(attack);
        }
    }
}