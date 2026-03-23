using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Payment_System
{
    internal class CreditCard : GoldenCard
    {
        private double _limit;
        public double Limit { get;}
        public CreditCard(double balance, double limit): base(balance)
        { 
            _limit = limit;
        }

        public override void Charge(double amount)
        {
            if(Balance + _limit >= amount)
            {
                if(Balance >= amount)
                {
                    _balance -= amount;
                }
                else
                {
                    _balance -= amount;
                    _limit += _balance;
                }
                Console.WriteLine($"Balance {_balance} Limit: {_limit}");
            }
        }
    }
}
