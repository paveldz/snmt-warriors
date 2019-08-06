namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public abstract class DefaultPassiveSkill : IPassiveSkill
    {
        public virtual IAttack ProduceAttack(IAttack initialAttack)
        {
            return initialAttack;
        }

        public virtual IAttack HandleAttack(IAttack initialAttack)
        {
            return initialAttack;
        }
    }
}