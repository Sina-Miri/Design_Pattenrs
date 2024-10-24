using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy
{
    public class ConcreteStrategyA : IStrategy
    {
        /*
         Concrete Strategies implement different variations of an algorithm the context uses.
         */
        public void Execute()
        {
            Console.WriteLine("Algoritm A");
        }
    }
}
