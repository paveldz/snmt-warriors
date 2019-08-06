using System;
using SnmtWarriors.Domain.Factories;

namespace SnmtWarriors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var swordsman = UnitFactory.CreateSwordsman();
            var archer = UnitFactory.CreateArcher();
            var paladin = UnitFactory.CreatePaladin();

            swordsman.Attack(archer);
            archer.AttackWithActiveSkill(swordsman);
            
            paladin.Attack(swordsman);
        }
    }
}