using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class Stub0CoinPaymentProcessor : IPaymentProcessor
    {
        public double payment;

        public double ReturnPayment()
        {
            return 0;
        }

        public void MakePayment(double amount)
        {
        }

        public bool IsPaymentMade(double price)
        {
            return false;
        }

        public double ReturnChange()
        {
            return 0;
        }

        public void ProcessPayment(double amount)
        {

        }
    }
}
