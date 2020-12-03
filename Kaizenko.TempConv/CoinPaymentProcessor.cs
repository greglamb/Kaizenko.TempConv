using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class CoinPaymentProcessor : IPaymentProcessor
    {
        public double payment;

        public double ReturnPayment()
        {
            //throw new NotImplementedException();

            double change = payment;
            payment = 0;
            return change;
        }

        public void MakePayment(double amount)
        {
            //throw new NotImplementedException();

            payment = payment + 25;
        }

        public bool IsPaymentMade(double price)
        {
            //throw new NotImplementedException();

            return payment >= price;
        }

        public void ProcessPayment(double amount)
        {
            //throw new NotImplementedException();

            payment = payment - amount;
        }
    }
}
