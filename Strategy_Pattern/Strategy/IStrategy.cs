using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy
{
    /*
     The Strategy interface is common to all concrete strategies. 
     It declares a method the context uses to execute a strategy.
     */
    public interface IStrategy
    {
        void Execute();
    }
}
