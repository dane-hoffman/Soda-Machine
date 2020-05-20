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
                for (int i = 0; i < 50; i++)
                {
                    Penny penny = new Penny();
                    coinsInWallet.Add(penny);
                }

                for (int i = 0; i < 20; i++)
                {
                    Nickle nickle = new Nickle();
                    coinsInWallet.Add(nickle);
                }

                for (int i = 0; i < 10; i++)
                {
                    Dime dime = new Dime();
                    coinsInWallet.Add(dime);
                }

                for (int i = 0; i < 20; i++)
                {
                    Quarter quarter = new Quarter();
                    coinsInWallet.Add(quarter);
                }


  
            }


        }


    }


}
