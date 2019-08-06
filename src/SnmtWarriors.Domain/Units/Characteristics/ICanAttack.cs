using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units.Characteristics
{
    public interface ICanAttack
    {
        void Attack(UnitBase unit);
    }
}