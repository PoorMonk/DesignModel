using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("请输入单价：");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数量：");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请选择优惠活动：\n Normal\tThreeDiscount\tFullReduce");
            string preferential = Console.ReadLine();

            CashContext context = new CashContext(preferential);
            double money = context.GetResult(price * count);
            Console.WriteLine("最后价格为：" + money);
        }
    }
}
