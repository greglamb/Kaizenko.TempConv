using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class Stub50CoinPaymentProcessor : IPaymentProcessor
    {
        public double payment;

        public double ReturnPayment()
        {
            return 50;
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
            return 50;
        }

        public void ProcessPayment(double amount)
        {

        }
    }
}
