using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterFace
{
    internal class Cola : IItem
    {
        public int GetPrice()
        {
            return 10;
        }
    }
}
