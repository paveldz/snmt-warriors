using System;
using SnmtWarriors.Domain.Units;
using SnmtWarriors.Domain.Units.Modules.Impl;

namespace SnmtWarriors.Domain.Factories
{
    public static class UnitFactory
    {
        public static Swordsman CreateSwordsman()
        {
            return new Swordsman(
                id: Guid.NewGuid().ToString(),
                name: nameof(Swordsman),
                healthPoints: 500,
                damage: new Damage(20, 30),
                armor: new Armor(2)
            );
        }
        
        public static Archer CreateArcher()
        {
            return new Archer(
                id: Guid.NewGuid().ToString(),
                name: nameof(Archer),
                healthPoints: 300,
                manaPoints: 100,
                damage: new Damage(15, 20),
                activeSkill: new ShotActiveSkill(100, 50)
            );
        }

        public static ArcherCaptain CreateArcherCaptain()
        {
            return new ArcherCaptain(
                id: Guid.NewGuid().ToString(),
                name: nameof(ArcherCaptain),
                healthPoints: 600, 200,
                damage: new Damage(30, 35),
                activeSkill: new ShotActiveSkill(150, 50),
                armor: new Armor(1)
            );
        }

        public static Skeleton CreateSkeleton()
        {
            return new Skeleton(
                id: Guid.NewGuid().ToString(),
                name: nameof(Skeleton),
                healthPoints: 180,
                damage: new Damage(5, 8),
                armor: new Armor(1),
                new CriticalStrikePassiveSkill(attackMultiplier: 2, probability: 20));
        }

        public static Paladin CreatePaladin()
        {
            return new Paladin(
                id: Guid.NewGuid().ToString(),
                name: nameof(Paladin),
                healthPoints: 700,
                manaPoints: 300,
                damage: new Damage(40, 50),
                armor: new Armor(5),
                passiveSkill: new CriticalStrikePassiveSkill(attackMultiplier: 3, probability: 30));
        }
    }
}