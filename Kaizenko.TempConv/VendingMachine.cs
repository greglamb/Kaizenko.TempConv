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
            //throw new NotImplementedException();

            paymentProcessor = new PaymentProcessor();
        }

        public double ReleaseChange()
        {
            //throw new NotImplementedException();

            return paymentProcessor.ReturnChange();
        }

        public void InsertCoin()
        {
            //throw new NotImplementedException();

            paymentProcessor.MakePayment(25);
        }

        public Product BuyProduct()
        {
            //throw new NotImplementedException();

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
