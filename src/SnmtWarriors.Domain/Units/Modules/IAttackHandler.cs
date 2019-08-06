namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IAttackHandler
    {
        IAttack HandleAttack(IAttack initialAttack);
    }
}