using System;

namespace Decorator
{
    public class NikeShoes : Finery
    {
        public override void Show()
        {
            Console.Write("耐克鞋");
            base.Show();
        }
    }
}