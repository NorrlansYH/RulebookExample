using System;
using Core.Interfaces;
using Rulebook.Interfaces;

namespace Rulebook
{
    public class BasicRulebookChecks : IRulebookChecks
    {
        private readonly ICharacter _character;
        private readonly IWieldable _item;

        public BasicRulebookChecks(ICharacter character)
        {
            _character = character;
            Can = new BasicCharacterActionChecks(_character);
        }

        public BasicRulebookChecks(IWieldable item)
        {
            _item = item;
            OneHand = new BasicCharacterActionChecks(_item);
        }

        public ICharacterActions Can { get; }
        public ICharacterActions OneHand { get; }
    }
}