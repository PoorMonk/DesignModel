using System;

namespace AbstractFactory
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override void Show()
        {
            Console.WriteLine("来自广东的产品B");
        }
    }
}