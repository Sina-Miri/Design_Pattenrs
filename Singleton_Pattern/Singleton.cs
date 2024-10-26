using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class Singleton
    {
        private static Singleton _singleton;
        private Singleton()
        {}


        public static Singleton GetInstance()
        {
            if(_singleton is not Singleton)
                _singleton = new Singleton();

            return _singleton;
        }
    }
}
