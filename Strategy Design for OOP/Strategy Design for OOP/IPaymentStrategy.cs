using Strategy_Design_for_OOP.PaymentStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_for_OOP
{
    abstract class IPaymentStrategy
    {
        public abstract void Pay(double amount, IPaymentMethodStrategy Payment);
    }
}
 