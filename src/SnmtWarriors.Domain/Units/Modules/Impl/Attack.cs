namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class DefaultAttack : IAttack
    {
        public DefaultAttack(string targetId, int damage)
        {
            TargetId = targetId;
            Damage = damage;
        }
        
        public string TargetId { get; }
        
        public int Damage { get; }

        public static IAttack CreateZero(string targetId) => new DefaultAttack(targetId, 0);
    }
}