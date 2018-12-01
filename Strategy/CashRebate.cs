namespace Strategy
{
    public class CashRebate : CashBasic
    {
        private double _moneyRebate = 1f;
        
        public CashRebate(double moneyRebate)
        {
            _moneyRebate = moneyRebate;
        }
        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}