using System;

namespace SimpleFactory
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

            Operation op = OperationFactory.CreateOperation(strOp);
            if (op == null)
            {
                Console.WriteLine("没有对应的操作符.");
                return;
            }
            Console.WriteLine("{0}{1}{2}={3}", dNum1, strOp, dNum2, op.GetResult(dNum1, dNum2));
        }
    }
}
