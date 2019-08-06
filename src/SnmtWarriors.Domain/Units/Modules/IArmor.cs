namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IArmor : IAttackHandler
    {
        int ArmorPoints { get; }
    }
}