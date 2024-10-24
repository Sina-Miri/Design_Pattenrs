using Observer_Pattern.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Subject
{
    /*
     The Subject is the object which holds the value and takes responsibility in notifying the observers when the value is changed. 
     The subject could be a database change, property change or so.
     */
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);

        void Notify();
    }
}
