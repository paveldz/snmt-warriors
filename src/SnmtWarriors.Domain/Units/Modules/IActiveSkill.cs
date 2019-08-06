namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IActiveSkill : IAttackProducer
    {
        int RequiredManaPoints { get; }
    }
}