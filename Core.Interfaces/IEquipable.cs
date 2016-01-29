using System;
using Core.Interfaces.Classifications;

namespace Core.Interfaces
{
    public interface IEquipable
    {
        Int32 MinLevel { get; }
        Armortype Armortype { get; }
    }
}

