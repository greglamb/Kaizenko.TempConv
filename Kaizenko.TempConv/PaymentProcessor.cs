using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class PaymentProcessor
    {
        public double payment;

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

        public double ReturnChange()
        {
            //throw new NotImplementedException();
            var change = payment;
            payment = 0;
            return change;
        }

        public void SpendPayment(double amount)
        {
            payment = payment - amount;
        }
    }
}
