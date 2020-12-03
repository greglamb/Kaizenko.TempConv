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
        VendingMachine vendingMachine;

        [SetUp]
        public void Setup()
        {
            IPaymentProcessor paymentProcessor = new StubCoinPaymentProcessor();
            vendingMachine = new VendingMachine(paymentProcessor);
        }

        [Test]
        public void GetMessage_WhenNoChange_Expect_SorryMessage()
        {
            // arrange
            vendingMachine.ReleaseChange();
            
            // act
            String message = vendingMachine.GetMessage();

            // assert
            Assert.AreEqual("Sorry no change left", message);
        }

    }
}
