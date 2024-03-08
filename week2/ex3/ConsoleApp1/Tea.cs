using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tea : CaffeinBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding the lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Sleeping the tea");
        }
    }
}
