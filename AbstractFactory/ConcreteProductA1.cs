using System;

namespace AbstractFactory
{
    public class ConcreteProductA1 : AbstractProductA
    {
        public override void Show()
        {
            Console.WriteLine("来自湖南的产品A");
        }
    }
}