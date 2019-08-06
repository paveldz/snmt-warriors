namespace SnmtWarriors.Domain.Units.Modules
{
    public interface IAttack
    {
        string TargetId { get; }
        
        int Damage { get; }
    }
}