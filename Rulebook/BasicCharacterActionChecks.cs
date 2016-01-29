using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Interfaces.Classifications;
using Rulebook.Interfaces;

namespace Rulebook
{
    public class BasicCharacterActionChecks : ICharacterActions
    {
        private readonly ICharacter _character;

        private readonly IDictionary<Class, IList<ItemMaterial>> _wieldableMaterials =
            new Dictionary<Class, IList<ItemMaterial>>();

        private readonly IDictionary<Class, IList<ItemType>> _wieldableTypes = new Dictionary<Class, IList<ItemType>>();
        private readonly IDictionary<Class, IList<Armortype>> _armorTypes = new Dictionary<Class, IList<Armortype>>();

        public BasicCharacterActionChecks(ICharacter character)
        {
            _character = character;
            _wieldableTypes.Add(Class.Wizard, new List<ItemType>
            {
                ItemType.Staff
            });
            _wieldableMaterials.Add(Class.Wizard, new List<ItemMaterial>
            {
                ItemMaterial.Clay,
                ItemMaterial.Stone,
                ItemMaterial.Wood
            });
            _armorTypes.Add(Class.Wizard, new List<Armortype>
            {
                Armortype.Cloth
            });

        }

        public Boolean Wield(Object item)
        {
            var wieldable = item as IWieldable;
            if (wieldable == null)
                return false;

            return _wieldableTypes[_character.Class].Contains(wieldable.ItemType)
                   && _character.Level >= wieldable.MinLevel;
        }

        public object Attack(object obj)
        {
            var type = obj.GetType();
            var target = obj as ICharacter;
            if (target == null)
                return false;
            return _character.WieldedWeapon != null;
        }

        public bool Equip(object item)
        {
            var equipable = item as IEquipable;
            if (equipable == null)
                return false;

            return _armorTypes[_character.Class].Contains(equipable.Armortype)
                   && _character.Level >= equipable.MinLevel;
        }



    }
}