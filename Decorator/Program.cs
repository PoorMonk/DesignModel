using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person("Harkey");
            TShirts ts = new TShirts();
            BigTrouser bt = new BigTrouser();
            NikeShoes ns = new NikeShoes();

            ns.Decorate(ps);
            bt.Decorate(ns);
            ts.Decorate(bt);
            ts.Show();
        }
    }
}
