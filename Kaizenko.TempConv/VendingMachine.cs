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
        String displayMsg = "";

        public VendingMachine(IPaymentProcessor paymentProcessor)
        {
            //throw new NotImplementedException();

            this.paymentProcessor = paymentProcessor;
        }

        public double ReleaseChange()
        {
            //throw new NotImplementedException();

            double change = paymentProcessor.ReturnPayment();

            if (change == 0)
            {
                displayMsg = "Sorry no change left";
            }
            else
            {
                displayMsg = "Please take your change";
            }

            return change;
        }

        public String GetMessage()
        {
            return displayMsg;
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
