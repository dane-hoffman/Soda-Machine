using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Dime : Coin
    {
        public Dime(double Value, string name)
        {
            Value = 0.10;
            this.name = "Dime";

        }
    }
}
