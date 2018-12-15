using System;

namespace AbstractFactory
{
    public class ConcreteProductB1 : AbstractProductB
    {
        public override void Show()
        {
            Console.WriteLine("来自湖南的产品B");
        }
    }
}