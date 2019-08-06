namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IDamage : IAttackProducer
    {
        IDamageRange DamageRange { get; }
    }
}