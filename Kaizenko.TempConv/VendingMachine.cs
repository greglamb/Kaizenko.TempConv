using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class VendingMachine
    {
        public IPaymentProcessor paymentProcessor;

        public VendingMachine(IPaymentProcessor paymentProcessor)
        {
            //throw new NotImplementedException();

            this.paymentProcessor = paymentProcessor;
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
                paymentProcessor.ProcessPayment(50);
                return new Product();
            }
            else
            {
                return null;
            }
        }
    }
}
