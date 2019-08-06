using SnmtWarriors.Domain.Units.Characteristics;
using SnmtWarriors.Domain.Units.Modules;
using SnmtWarriors.Domain.Units.Modules.Impl;

namespace SnmtWarriors.Domain.Units
{
    public class Archer : UnitWithAttackBase, IWithActiveSkill, IWithMana
    {
        private readonly IMultipleAttackProducer _activeAttackModule;
        
        public Archer(
            string id,
            string name,
            int healthPoints,
            int manaPoints,
            IDamage damage,
            IActiveSkill activeSkill) 
            : base(id, name, healthPoints, damage)
        {
            _activeAttackModule = new DefaultAttackModule(activeSkill);
            
            ManaPoints = manaPoints;
            ActiveSkill = activeSkill;
        }

        public IActiveSkill ActiveSkill { get; }
        
        public int ManaPoints { get; private set; }

        public void AttackWithActiveSkill(UnitBase unit)
        {
            var actualAttack = DefaultAttack.CreateZero(unit.Id);
            
            if (ManaPoints >= ActiveSkill.RequiredManaPoints)
            {
                ManaPoints -= ActiveSkill.RequiredManaPoints;
                actualAttack = _activeAttackModule.ProduceAttack(actualAttack);
            }

            unit.TakeAttack(actualAttack);
        }
    }
}