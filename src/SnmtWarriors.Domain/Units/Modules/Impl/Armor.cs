namespace SnmtWarriors.Domain.Units.Modules.Impl
{
    public class Armor : IArmor
    {
        public Armor(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
        
        public int ArmorPoints { get; }
        
        public IAttack HandleAttack(IAttack initialAttack)
        {
            int actualDamage = initialAttack.Damage - ArmorPoints;
            actualDamage = actualDamage >= 0
                ? actualDamage
                : 0;
            
            return new DefaultAttack(initialAttack.TargetId, actualDamage);
        }
    }
}