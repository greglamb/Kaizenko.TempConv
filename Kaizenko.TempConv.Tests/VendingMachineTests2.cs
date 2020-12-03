using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;

namespace Kaizenko.TempConv.Tests
{
    class VendingMachineTests2
    {
        [Test]
        public void GetMessage_WhenNoChange_Expect_SorryMessage()
        {
            // arrange
            IPaymentProcessor paymentProcessor = new Stub0CoinPaymentProcessor();
            VendingMachine vendingMachine = new VendingMachine(paymentProcessor);

            vendingMachine.ReleaseChange();
            
            // act
            String message = vendingMachine.GetMessage();

            // assert
            Assert.AreEqual("Sorry no change left", message);
        }

        [Test]
        public void GetMessage_WhenChange_Expect_TakeChange()
        {
            // arrange
            IPaymentProcessor paymentProcessor = new Stub50CoinPaymentProcessor();
            VendingMachine vendingMachine = new VendingMachine(paymentProcessor);

            vendingMachine.ReleaseChange();

            // act
            String message = vendingMachine.GetMessage();

            // assert
            Assert.AreEqual("Please take your change", message);
        }

    }
}
