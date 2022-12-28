using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_for_OOP.PaymentStrategy
{
    internal class PayWithPayPal : IPaymentStrategy
    {
        public override void Pay(double amount, IPaymentMethodStrategy Payment)
        {
            List<string> details = Payment.RetrievePaymentDetails();
            Console.WriteLine("-----RECIPT-----");
            Console.WriteLine("PayPal Email: " + details[0]);
            Console.WriteLine("PayPal Password: " + details[1]);
            Console.WriteLine("Total: " + amount);
        }
    }
}
