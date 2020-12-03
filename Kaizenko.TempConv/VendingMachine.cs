using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class VendingMachine
    {
        public PaymentProcessor paymentProcessor;

        public VendingMachine()
        {
            paymentProcessor = new PaymentProcessor();
        }

        public double ReleaseChange()
        {
            return paymentProcessor.ReturnChange();
        }

        public void InsertCoin()
        {
            paymentProcessor.MakePayment(25);
        }

        public Product BuyProduct()
        {
            if (paymentProcessor.IsPaymentMade(50))
            {
                paymentProcessor.SpendPayment(50);
                return new Product();
            }
            else
            {
                return null;
            }
        }
    }
}
