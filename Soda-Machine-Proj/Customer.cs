using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;


        public Customer()
        {
            this.wallet = new Wallet();
            this.backpack = new Backpack();


        }


    }


}
