using System;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core.Weapons
{
    public class IronDagger : IWeapon
    {
        public Int32 MinLevel { get; } = 2;
        public ItemType ItemType { get; } = ItemType.Dagger;
    }
}