using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subscribers : ISubscribers
    {
        public string SubscribersName { get; private set; }

        public Subscribers(string name)
        {
            SubscribersName = name;
        }

        public void Update()
        {
            Console.WriteLine(SubscribersName + " How To has published a new video!");
        }
    }
}
