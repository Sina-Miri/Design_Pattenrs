using Strategy_Pattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Context
{
    /*
     The Context maintains a reference to one of the concrete strategies and communicates with this object only via the strategy interface.
     */
    public class Context
    {
        private IStrategy _strategy; 

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();    
        }
    }
}
