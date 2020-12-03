using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;

namespace Kaizenko.TempConv.Tests
{
    class CoinPaymentProcessorTests
    {
        IPaymentProcessor paymentProcessor;

        [SetUp]
        public void Setup()
        {
            paymentProcessor = new CoinPaymentProcessor();
        }

        //[Test]
        public void Something()
        {
            // arrange

            // act

            // asset
            //Assert.AreEqual(0, );
        }
    }
}
