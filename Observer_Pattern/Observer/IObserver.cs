using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Subscriber
{
    public interface IObserver
    {
        void Update(Color color);
    }
}
