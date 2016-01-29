using System;

namespace Rulebook.Interfaces
{
    public interface ICharacterActions
    {
        Boolean Wield(Object item);
        Boolean Onehand(Object item);
    }
}