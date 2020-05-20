using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class SodaMachine
    {
        public List<Coin> register;
        public List<Can> inventory;



        public SodaMachine()
        {
            register = new List<Coin>();
            {
                for(int i = 0; i < 50; i++)   
                {
                    Penny penny = new Penny();
                    register.Add(penny);
                }

                for(int i = 0; i < 20; i++)
                {
                    Nickle nickle = new Nickle();
                    register.Add(nickle);
                }
                
                for(int i = 0; i < 10; i++)
                {
                    Dime dime = new Dime();
                    register.Add(dime);
                }

                for(int i = 0; i < 20; i++)
                {
                    Quarter quarter = new Quarter();

                }

            }


            inventory = new List<Can>();
            {
                Cola cola = new Cola();
                OrangeSoda orangeSoda = new OrangeSoda();
                RootBeer rootBeer = new RootBeer();

                inventory.Add(cola);
                inventory.Add(orangeSoda);
                inventory.Add(rootBeer);



            }





        }


    }


}
