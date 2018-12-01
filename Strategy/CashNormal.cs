namespace Strategy
{
    public class CashNormal : CashBasic
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}