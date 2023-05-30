using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class Utilities : Item, IUsable
    {
        public Utilities() { }
        public Utilities(int baseStrength, string description, Rarity itemRarity, Stats itemStats, string name, int price) : base(baseStrength, description, itemRarity, itemStats, name, price) { }
        public int ItemStrength()
        {
            return BaseStrength * (1 + (int)ItemRarity);
        }

        public string UseItem(IUsable.Usable usable)
        {
            return usable(this);
        }
    }
}
