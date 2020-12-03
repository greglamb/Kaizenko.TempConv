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
            IPaymentProcessor paymentProcessor = new CoinPaymentProcessor();
            vendingMachine = new VendingMachine(paymentProcessor);
        }

        [Test]
        public void ReleaseChange_WhenNoMoneyInserted_Expect0()
        {
            // arrange

            // act
            double change = vendingMachine.ReleaseChange();
            // asset
            Assert.AreEqual(0, change);
        }

        [Test]
        public void RelaseChange_WhenMoney25Inserted_Expected25()
        {
            // arrange
            vendingMachine.InsertCoin();
            // act
            double change = vendingMachine.ReleaseChange();
            // assert
            Assert.AreEqual(25, change);
        }

        [Test]
        public void RelaseChange_WhenMoney50Inserted_Expected50()
        {
            // arrange
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            // act
            double change = vendingMachine.ReleaseChange();
            // assert
            Assert.AreEqual(50, change);
        }

        [Test]
        public void ReleaseChange_WhenChangeAlreadyReleased_Expect0()
        {
            // arrange
            vendingMachine.InsertCoin();
            vendingMachine.ReleaseChange();

            // act
            double change = vendingMachine.ReleaseChange();

            // assert
            Assert.AreEqual(0, change);
        }

        [Test]
        public void BuyProduct_WhenNoMoneyInserted_ExpectNoProduct()
        {
            // arrange

            // act
            Product product = vendingMachine.BuyProduct();
            // assert
            Assert.IsNull(product);
        }

        [Test]
        public void BuyProduct_When50cIsInserted_ExpectProduct()
        {
            // arrange
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            // act
            Product product = vendingMachine.BuyProduct();
            // assert
            Assert.IsNotNull(product);
        }

        [Test]
        public void ReleaseChange_WhenBuyingProductWith75C_Expect25C()
        {
            // arrange
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            vendingMachine.InsertCoin();
            Product product = vendingMachine.BuyProduct();
            // act
            double change = vendingMachine.ReleaseChange();
            // assert
            Assert.AreEqual(25, change);
        }

    }
}
