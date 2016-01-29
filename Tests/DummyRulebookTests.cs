using System;
using Core;
using Core.Armor;
using Core.Weapons;
using NUnit.Framework;
using Rulebook;

namespace Tests
{
    [TestFixture]
    public class DummyRulebookTests
    {
        private readonly DummyRulebook _god = new DummyRulebook();

        [Test]
        public void AcceptsWieldingLegal()
        {
            var character = new Wizard
            {
                Level = Int32.MaxValue
            };
            var item = new Staff();

            var result =
                _god.Says(character).Can.Wield(item);

            Assert.That(result, Is.True);
        }

        [Test]
        public void AcceptsEquipingArmor()
        {
            var character = new Wizard();
            var item = new ClothArmor();

            var result =
                _god.Says(character).Can.Equip(item);
        }

        [Test]
        public void ChecksWieldingByLevel()
        {
            var character = new Wizard
            {
                Level = 10
            };
            var item1 = new Staff
            {
                MinLevel = 5
            };

            var result1 =
                _god.Says(character).Can.Wield(item1);

            Assert.That(result1, Is.True, "Failed for legal item.");

            var item2 = new Staff
            {
                MinLevel = 100
            };
            var result2 =
                _god.Says(character).Can.Wield(item2);

            Assert.That(result2, Is.False, "Failed for illegal item.");
        }

        [Test]
        public void RefusesWieldingIllegalItem()
        {
            var character = new Wizard() {WieldedWeapon = new IronDagger()};
            var item = new IronDagger();

            var result =
                _god.Says(character).Can.Wield(item);

            Assert.That(result, Is.False);
        }

        [Test]
        public void RefuseAttackIllegalObject()
        {
            var character = new Wizard() {WieldedWeapon = new IronDagger()};
            var item = new IronDagger();
            
            var result = _god.Says(character).Can.Attack(item);
            Assert.That(result,Is.False);

        }
        [Test]
        public void AcceptAttackLegalObject()
        {
            var character = new Wizard() {WieldedWeapon = new IronDagger()};
            var character2 = new Wizard();
            var item = new IronDagger();
            var result = _god.Says(character).Can.Attack(character2);
            Assert.That(result,Is.True);
        }
    }
}