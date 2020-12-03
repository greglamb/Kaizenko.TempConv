using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;
using Moq;

namespace Kaizenko.TempConv.Tests
{
    class VendingMachineTests2
    {
        VendingMachine vendingMachine;
        Mock<IPaymentProcessor> mockPaymentProcessor = new Mock<IPaymentProcessor>();

        [SetUp]
        public void Setup()
        {
            vendingMachine = new VendingMachine(mockPaymentProcessor.Object);
        }

        [Test]
        public void GetMessage_WhenNoChange_Expect_SorryMessage()
        {
            // arrange
            mockPaymentProcessor.Setup(p => p.ReturnPayment()).Returns(0);
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
            mockPaymentProcessor.Setup(p => p.ReturnPayment()).Returns(50);
            vendingMachine.ReleaseChange();

            // act
            String message = vendingMachine.GetMessage();

            // assert
            Assert.AreEqual("Please take your change", message);
        }

    }
}
