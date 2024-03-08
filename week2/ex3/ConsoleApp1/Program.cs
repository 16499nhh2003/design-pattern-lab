using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeinBeverage teaBeverage = new Tea();
            teaBeverage.prepareRecipe();

            CaffeinBeverage caffeinBeverage = new Coffee();    
            caffeinBeverage.prepareRecipe();    

        }

    }
}
