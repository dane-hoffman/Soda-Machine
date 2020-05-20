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
                Penny penny = new Penny();
                Nickle nickle = new Nickle();
                Dime dime = new Dime();
                Quarter quarter = new Quarter();

                coinsInWallet.Add(penny);
                coinsInWallet.Add(nickle);
                coinsInWallet.Add(dime);
                coinsInWallet.Add(quarter);

  
            }


        }


    }


}
