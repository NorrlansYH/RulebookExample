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
        }

        public Boolean Wield(Object item)
        {
            var wieldable = item as IWieldable;
            if (wieldable == null)
                return false;

            return _wieldableTypes[_character.Class].Contains(wieldable.ItemType)
                   && _character.Level >= wieldable.MinLevel;
        }
    }
}