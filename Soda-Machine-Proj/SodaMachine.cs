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
                Penny penny = new Penny();
                Nickle nickle = new Nickle();
                Dime dime = new Dime();
                Quarter quarter = new Quarter();

                register.Add(penny);
                register.Add(nickle);
                register.Add(dime);
                register.Add(quarter);

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
