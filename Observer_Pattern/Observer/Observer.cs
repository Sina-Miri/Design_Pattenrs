using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Subscriber
{
    public class Observer : IObserver
    {
        public void Update(Color color)
        {
            Console.WriteLine($"Color changed to {color.Name}");
        }
    }
}
