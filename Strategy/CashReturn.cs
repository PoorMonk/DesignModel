using System.Collections;
using System;

namespace Strategy
{
    public class CashReturn : CashBasic
    {
        private double _fullMoney;
        private double _reduceMoney;

        public CashReturn(double fullMoney, double reduceMoney)
        {
            _fullMoney = fullMoney;
            _reduceMoney = reduceMoney;
        }

        public override double AcceptCash(double money)
        {
            return money - Math.Floor(money / _fullMoney) * _reduceMoney;
        }
    }
}