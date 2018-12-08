using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract ab1 = new ConcreteA();
            ab1.TemplateMethod();

            Abstract ab2 = new ConcreteB();
            ab2.TemplateMethod();
        }
    }
}
