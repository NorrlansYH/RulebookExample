using System;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core
{
    public class Wizard : ICharacter
    {
        public Class Class { get; } = Class.Wizard;
        public Int32 Level => (Int32)(Math.Sqrt(Experience)/4);
        public double Experience { get; set; }
        public IWeapon WieldedWeapon { get; set; }
    }
}