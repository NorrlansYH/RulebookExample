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
        private readonly IWieldable _item;

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

        public BasicCharacterActionChecks(IWieldable item)
        {
            _item = item;


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
            var target = obj as ICharacter;
            if (target == null)
                return false;

            return true;
        }

        public bool LikeWeapon(object item)
        {
            var likebul = item as ILikebul;
            if (likebul != null)
                return false;

            return true;

        }
        public Boolean Onehand(Object item)
        {
            var inonehand = item as IWieldable;
            if (inonehand == null)
                return false;

            return inonehand.OneHand;
        }
    }
}