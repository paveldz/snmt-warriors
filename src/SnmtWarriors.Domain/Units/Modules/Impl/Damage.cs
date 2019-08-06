namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class Damage : IDamage
    {
        public Damage(int min, int max)
        {
            DamageRange = new DamageRange(min, max);
        }
        
        public IDamageRange DamageRange { get; }
        
        public IAttack ProduceAttack(IAttack initialAttack)
        {
            // TODO: set actual damage in [min;max] range
            var actualAttack = new DefaultAttack(initialAttack.TargetId, DamageRange.Max);
            return actualAttack;
        }
    }
}