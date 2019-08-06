using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units.Characteristics
{
    public interface IWithPassiveSkill
    {
        IPassiveSkill PassiveSkill { get; }
    }
}