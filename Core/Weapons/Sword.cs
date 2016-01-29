using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.Classifications;

namespace Core.Weapons
{
    public class Sword: IWeapon
    {
        public int MinLevel { get; }
        public ItemType ItemType { get; } = ItemType.Sword;
    }
}
