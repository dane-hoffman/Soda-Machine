using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Wallet
    {
        public List<Coin> coinsInWallet;
        


        public Wallet()
        {
            coinsInWallet = new List<Coin>();
            {
                Coin penny = new Penny(); 
                Coin nickle = new Nickle(); 
                Coin dime = new Dime(); 
                Coin quarter = new Quarter(); 
                

            }


        }


    }


}
