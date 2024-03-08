using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class CaffeinBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            Brew();
            pourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();
        void boilWater()
        {
            Console.WriteLine("boiling water ");
        }

        void pourInCup() {
            Console.WriteLine("Pouring into cup");
        }

    }
}
