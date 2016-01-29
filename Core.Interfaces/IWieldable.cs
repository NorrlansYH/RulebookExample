using System;
using Core.Interfaces.Classifications;

namespace Core.Interfaces
{
    public interface IWieldable
    {
        Int32 MinLevel { get; }
        ItemType ItemType { get; }
        Boolean OneHand { get; }
    }
}