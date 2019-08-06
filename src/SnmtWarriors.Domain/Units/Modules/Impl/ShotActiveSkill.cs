namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class ShotActiveSkill : IActiveSkill
    {
        private readonly int _damage;
        
        public ShotActiveSkill(int damage, int requiredMana)
        {
            _damage = damage;
            RequiredManaPoints = requiredMana;
        }
        
        public int RequiredManaPoints { get; }
        
        public IAttack ProduceAttack(IAttack initialAttack)
        {
            return new DefaultAttack(initialAttack.TargetId, _damage);
        }
    }
}