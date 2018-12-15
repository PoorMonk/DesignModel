using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory af = new ConcreteFactory1();
            AbstractProductA apA = af.CreateProductA();
            AbstractProductB apB = af.CreateProductB();
            apA.Show();
            apB.Show();

            af = new ConcreteFactory2();
            apA = af.CreateProductA();
            apB = af.CreateProductB();
            apA.Show();
            apB.Show();
        }
    }
}
