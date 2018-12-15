using System;

namespace Publish
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cs = new ConcreteSubject();

            cs.Attach(new ConcreteObserver(cs, "X"));
            cs.Attach(new ConcreteObserver(cs, "Y"));
            cs.Attach(new ConcreteObserver(cs, "Z"));

            cs.SubjectState = "ABC";
            cs.Notify();
        }
    }
}
