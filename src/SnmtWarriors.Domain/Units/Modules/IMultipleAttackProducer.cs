namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IMultipleAttackProducer : IAttackProducer
    {
        void AddAttackProducer(IAttackProducer attackProducer);
    }
}