using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_for_OOP
{
    abstract class IPaymentMethodStrategy
    {
        public abstract void GetPaymentDetails();
        public abstract List<string> RetrievePaymentDetails();
    }
}
