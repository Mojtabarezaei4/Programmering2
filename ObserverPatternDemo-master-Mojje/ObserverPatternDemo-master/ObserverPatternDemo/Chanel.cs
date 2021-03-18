using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Chanel : IChanel
    {
        private List<Subscribers> subscribers = new List<Subscribers>();
        private int _content;

        public int Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (value > _content)
                {
                    Notify();
                }
                _content = value;
            }
        }

        public void Subscribe(Subscribers observer)
        {
            subscribers.Add(observer);
        }

        public void Unsubscribe(Subscribers observer)
        {
            subscribers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
