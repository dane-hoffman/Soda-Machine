using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    public abstract class Coin
    {
       
        private readonly double value;//field
        public double Value//property
        {
            get
            {
                return value;
            }
        }

        public string name;


        
        public Coin()
        {
            this.value = Value;



        }



    }



}
