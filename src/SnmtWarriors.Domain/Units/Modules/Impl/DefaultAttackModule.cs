using System.Collections.Generic;

namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class DefaultAttackModule : IMultipleAttackProducer
    {
        private readonly List<IAttackProducer> _attackProducers = new List<IAttackProducer>();
        
        public DefaultAttackModule(IAttackProducer defaultAttackProducer)
        {
            _attackProducers.Add(defaultAttackProducer);
        }
        
        public IAttack ProduceAttack(IAttack initialAttack)
        {
            IAttack actualAttack = initialAttack;
            foreach (IAttackProducer attackProducer in _attackProducers)
            {
                actualAttack = attackProducer.ProduceAttack(actualAttack);
            }

            return actualAttack;
        }

        public void AddAttackProducer(IAttackProducer attackProducer)
        {
            _attackProducers.Add(attackProducer);
        }
    }
}