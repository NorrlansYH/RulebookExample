using Core.Interfaces;
using Rulebook.Interfaces;

namespace Rulebook
{
    public class BasicRulebookChecks : IRulebookChecks
    {
        private readonly ICharacter _character;

        public BasicRulebookChecks(ICharacter character)
        {
            _character = character;
            Can = new BasicCharacterActionChecks(_character);
        }

        public ICharacterActions Can { get; }
    }
}