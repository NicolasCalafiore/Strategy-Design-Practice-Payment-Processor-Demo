using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_for_OOP.PaymentStrategy
{
    internal class PayWithCreditStrategy : IPaymentStrategy
    {
        public PayWithCreditStrategy() {

        }  
        public override void Pay(double amount, IPaymentMethodStrategy Payment)
        {
            List<string> details = Payment.RetrievePaymentDetails();
            Console.WriteLine("-----RECIPT-----");
            Console.WriteLine("Card Number Charged: " + details[0]);
            Console.WriteLine("Card Expiration Date Charged: " + details[1]);
            Console.WriteLine("Card Security Code Charged: " + details[2]);
            Console.WriteLine("Total: " + amount);


        }
    }
}
