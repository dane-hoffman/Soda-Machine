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
                Coin penny = new Penny(0.01, "Penny"); 
                Coin nickle = new Nickle(0.05, "Nickle"); 
                Coin dime = new Dime(0.10, "Dime"); 
                Coin quarter = new Quarter(); 
                

            }


        }


    }


}
