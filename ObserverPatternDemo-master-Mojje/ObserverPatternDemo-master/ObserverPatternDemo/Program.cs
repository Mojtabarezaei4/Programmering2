using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chanel chanel = new Chanel();

            Subscribers matti = new Subscribers("Matti");
            chanel.Subscribe(matti);

            Subscribers moa = new Subscribers("Moa");
            chanel.Subscribe(moa);

            chanel.Content++;

            Subscribers agnes = new Subscribers("Agnes");
            chanel.Subscribe(agnes);

            chanel.Content++;

            chanel.Unsubscribe(agnes);
            chanel.Unsubscribe(moa);

            chanel.Content++;

            Console.ReadLine();
        }
    }
}
