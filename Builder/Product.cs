using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            System.Console.WriteLine("产品 创建 ----");
            foreach (string part in parts)
            {
                System.Console.WriteLine(part);
            }
        }
    }
}