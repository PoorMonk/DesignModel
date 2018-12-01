namespace Strategy
{
    public class CashContext
    {
        private CashBasic _cashBasic;
        public CashContext(string strType)
        {
            //_cashBasic = cashBasic;
            switch (strType)
            {
                // case "Normal":
                //     _cashBasic = new CashNormal();
                //     break;
                case "ThreeDiscount":
                    _cashBasic = new CashRebate(0.3);
                    break;
                case "FullReduce":
                    _cashBasic = new CashReturn(300, 100);
                    break;
                default:
                    _cashBasic = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cashBasic.AcceptCash(money);

        }
    }
}