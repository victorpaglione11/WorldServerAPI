using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldServer.Domain.Enums
{
    [System.Flags]
    public enum ItemCategory
    {
        None = 0,
        Consumable = 1 << 0, // 1
        Equippable = 1 << 1, // 2
        Weapon = 1 << 2, // 4
        Armor = 1 << 3, // 8
        Material = 1 << 4, // 16
        Quest = 1 << 5  // 32
    }

    // Exemplo de uso:
    // ItemCategory categoria = ItemCategory.Equippable | ItemCategory.Weapon;
}
