using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public interface IUsable
    {
        public delegate string Usable(Item item);
        public string UseItem(Usable usable);
    }
}
