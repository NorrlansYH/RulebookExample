using System;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core.Armor
{
    public class ClothArmor : IArmor
    {
        public Armortype Armortype { get; } = Armortype.Cloth;
        public Int32 MinLevel { get; set; } = 1;
        
    }
}
