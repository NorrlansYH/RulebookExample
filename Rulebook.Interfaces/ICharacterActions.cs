using System;

namespace Rulebook.Interfaces
{
    public interface ICharacterActions
    {
        Boolean Wield(Object item);
        object Attack(Object obj);
        Boolean LikeWeapon(Object item);
        Boolean Onehand(Object item);
    }
}