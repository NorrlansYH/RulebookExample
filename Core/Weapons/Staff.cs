using System;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core.Weapons
{
    public class Staff : IWeapon
    {
        public ItemType ItemType { get; } = ItemType.Staff;
        public Int32 MinLevel { get; set; } = 1;
        public Boolean OneHand => false;
    }
}