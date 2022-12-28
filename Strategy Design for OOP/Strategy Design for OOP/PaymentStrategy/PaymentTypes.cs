using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_for_OOP.PaymentStrategy
{
    internal class PaymentTypes
    {

        public class CreditCardDetails : IPaymentMethodStrategy
        {
            public string CardNumber { get; set; }
            public string ExpirationDate { get; set; }
            public string SecurityCode { get; set; }

            public override void GetPaymentDetails()
            {
                Console.WriteLine("Enter Card Number:");
                CardNumber = Console.ReadLine();
                Console.WriteLine("Enter Expiration Date (MM/YY):");
                ExpirationDate = Console.ReadLine();
                Console.WriteLine("Enter Security Code:");
                SecurityCode = Console.ReadLine();
            }
            public override List<string> RetrievePaymentDetails()
            {
                List<string> ret = new List<string>();
                ret.Add(CardNumber);
                ret.Add(ExpirationDate);
                ret.Add(SecurityCode);
                return ret;
            }
        }




        public class GiftCardDetails : IPaymentMethodStrategy
        {
            public string GiftCardNumber2;

            public override void GetPaymentDetails()
            {
                Console.WriteLine("Enter Gift Card Number:");
                GiftCardNumber2 = Console.ReadLine();

            }

            public override List<string> RetrievePaymentDetails()
            {
                List<string> ret = new List<string>();
                ret.Add(GiftCardNumber2);
                return ret;
            }
        }




        public class PayPalDetails : IPaymentMethodStrategy
        {
            public string PayPalAddress { get; set; }
            public string PayPalPass { get; set; }

            public override void GetPaymentDetails()
            {
                Console.WriteLine("Enter PayPal Address:");
                PayPalAddress = Console.ReadLine();
                Console.WriteLine("Enter PayPal Password:");
                PayPalPass = Console.ReadLine();

            }

            public override List<string> RetrievePaymentDetails()
            {
                List<string> ret = new List<string>();
                ret.Add(PayPalAddress);
                ret.Add(PayPalPass);
                return ret;
            }
        }

    }
}
