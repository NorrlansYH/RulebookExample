using System;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core
{
    public class Wizard : ICharacter
    {
        public Class Class { get; } = Class.Wizard;
        public Int32 Level { get; set; }
        public IWeapon WieldedWeapon { get; set; }
    }
}