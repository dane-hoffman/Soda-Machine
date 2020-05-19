using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    public abstract class Can
    {

        private double cost;//field
        public double Cost//property
        {
            get
            {
                return cost;
            }
        }

        public string name;



        public Can()
        {
            this.cost = Cost;
        }
    }
}
