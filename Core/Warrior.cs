using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core
{
    public class Warrior : ICharacter
    {
        public Class Class { get; } = Class.Warrior;
        public int Level { get; }
    }
}