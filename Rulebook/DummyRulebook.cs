using Core.Interfaces;
using Rulebook.Interfaces;

namespace Rulebook
{
    public class DummyRulebook
    {
        public IRulebookChecks Says(ICharacter character)
        {
            return new BasicRulebookChecks(character);
        }
    }
}