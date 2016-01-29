using System;
using Core;
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
            var character = new Wizard();
            var item = new IronDagger();

            var result =
                _god.Says(character).Can.Wield(item);

            Assert.That(result, Is.False);
        }

        [Test]
        public void RefuseAttackIllegalObject()
        {
            var character = new Wizard();
            var item = new IronDagger();
            var result = _god.Says(character).Can.Attack(item);

        }

        public void AcceptAttackLegalObject()
        {
            var character = new Wizard();
            var character2 = new Wizard();
            var item = new IronDagger();
            var result = _god.Says(character).Can.Attack(character2);
        }

        [Test]
        public void LikeWeaponType()
        {
            var caracter = new Warrior();
            var item = new Sword();
            var result = _god.Says(caracter).Can.LikeWeapon(item);

            Assert.That(result, Is.True, "Is realy Happy becose he got his favorite weapon");
            //     Assert.That(result, Is.False,"Dont get any bonuses bechose of weapon is not his favirote");

        }
        [Test]
        public void CanBeWieldedInOneHand()
        {
            var Char = new Wizard();
            var staff = new Staff();
            var dagger = new IronDagger();
            var resultat = _god.Says(Char).Can.Onehand(staff);

            Assert.That(resultat, Is.False);

            var resultat2 = _god.Says(Char).Can.Onehand(dagger);

            Assert.That(resultat2, Is.True);
        }
    }
}