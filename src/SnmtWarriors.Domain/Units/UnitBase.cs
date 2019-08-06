using System;
using System.Collections.Generic;
using SnmtWarriors.Domain.Units.Modules;

namespace SnmtWarriors.Domain.Units
{
    public abstract class UnitBase
    {
        protected readonly List<IAttackHandler> AttackHandlers = new List<IAttackHandler>();
        
        public UnitBase(string id, string name, int healthPoints)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            HealthPoints = healthPoints;
        }
        
        public string Id { get; }
        
        public string Name { get; }

        public int HealthPoints { get; protected set; }

        public virtual void TakeAttack(IAttack originalAttack)
        {
            IAttack actualAttack = originalAttack;
            foreach (IAttackHandler handler in AttackHandlers)
            {
                actualAttack = handler.HandleAttack(actualAttack);
            }
            
            int actualDamage = actualAttack.Damage > HealthPoints 
                ? HealthPoints 
                : actualAttack.Damage;

            HealthPoints -= actualDamage;
        }
    }
}