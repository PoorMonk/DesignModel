using System;

namespace Decorator
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("穿T恤 ");
            base.Show();
        }
    }
}