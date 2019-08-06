using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units.Characteristics
{
    public interface IWithActiveSkill
    {
        IActiveSkill ActiveSkill { get; }
        
        void AttackWithActiveSkill(UnitBase unit);
    }
}