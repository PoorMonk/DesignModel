using System;

namespace Decorator
{
    public class Person
    {
        private string _name;

        public Person()
        {

        }
        public Person(string name)
        {
            _name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("的{0}", _name);
        }
    }
}