using PaymentSystem.Payment_System;
namespace PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(500, 300);
            DebitCard debitCard = new DebitCard(500);
            ProcessPayment(creditCard, 700);
            ProcessPayment(debitCard, 700);
        }


        public static void ProcessPayment(GoldenCard card, double amount)
        {
            card.Charge(amount);
        }
    }
}
