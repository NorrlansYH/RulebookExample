using System;
using Core.Interfaces.Classifications;

namespace Core.Interfaces
{
    public interface ICharacter
    {
        Class Class { get; }
        Int32 Level { get; }
    }
}