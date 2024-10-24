using Observer_Pattern.Subscriber;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Subject
{
    public class ColorSubject : ISubject
    {
        private Color _color;
        public Color Color
        {
            get => _color;
            set 
            {
                _color = value;
                Notify();
            }
        }


        private HashSet<IObserver> observers = new HashSet<IObserver>();

        public void Notify()
        {
            observers.ToList().ForEach(observer => observer.Update(Color));
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
