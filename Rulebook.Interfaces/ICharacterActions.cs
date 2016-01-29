using System;

namespace Rulebook.Interfaces
{
    public interface ICharacterActions
    {
        Boolean Wield(Object item);
        object Attack(Object obj);
    }
}