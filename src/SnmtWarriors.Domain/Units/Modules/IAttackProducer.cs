namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IAttackProducer
    {
        IAttack ProduceAttack(IAttack initialAttack);
    }
}