using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            double dNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            double dNum2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            string strOp = Console.ReadLine();
            Factory factory = null;
            switch (strOp)
            {
                case "+":
                    factory = new AddFactory();
                    break;
                case "-":
                    factory = new SubFactory();
                    break;
                case "*":
                    factory = new MulFactory();
                    break;
                case "/":
                    factory = new DivFactory();
                    break;
                case "%":
                    factory = new ModuloFactory();
                    break;
                default:
                    Console.WriteLine("没有此工厂方法");
                    factory = null;
                    break;
            }
            if (factory != null) {
                Operation op = factory.CreateOperation();
                Console.WriteLine("{0}{1}{2}={3}", dNum1, strOp, dNum2, op.GetResult(dNum1, dNum2));
            }
        }
    }
}
