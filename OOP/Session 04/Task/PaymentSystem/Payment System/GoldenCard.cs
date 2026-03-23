using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Payment_System
{
    internal class GoldenCard
    {
        private protected double _balance;
        public double Balance 
        { 
            get
            {
                return _balance;
            }
        }

        public GoldenCard(double balance) 
        { 
            _balance = balance;
        }


        public virtual void Charge(double amount)
        {
            if(Balance >= amount)
                _balance -= amount;
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
