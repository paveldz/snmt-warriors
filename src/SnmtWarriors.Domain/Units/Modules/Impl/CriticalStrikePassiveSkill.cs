namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class CriticalStrikePassiveSkill : DefaultPassiveSkill
    {
        private readonly int _attackMultiplier;
        private readonly int _probability;

        public CriticalStrikePassiveSkill(int attackMultiplier, int probability)
        {
            _attackMultiplier = attackMultiplier;
            _probability = probability;
        }
        
        public override IAttack ProduceAttack(IAttack initialAttack)
        {
            // TODO
            return new DefaultAttack(initialAttack.TargetId, initialAttack.Damage * _attackMultiplier);
        }
    }
}