﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;

namespace Kaizenko.TempConv.Tests
{
    class VendingMachineTests
    {
        [Test]
        public void ReleaseChange_WhenNoMoneyInserted_Expect0()
        {
            // arrange
            VendingMachine vendingMachine = new VendingMachine();
            // act
            double change = vendingMachine.ReleaseChange();
            // asset
            Assert.AreEqual(0, change);
        }


        [Test]
        public void RelaseChange_WhenMoney25Inserted_Expected25()
        {
            // arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertCoin(25);
            // act
            double change = vendingMachine.ReleaseChange();
            // assert
            Assert.AreEqual(25, change);
        }

        [Test]
        public void RelaseChange_WhenMoney50Inserted_Expected50()
        {
            // arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertCoin(25);
            vendingMachine.InsertCoin(25);
            // act
            double change = vendingMachine.ReleaseChange();
            // assert
            Assert.AreEqual(50, change);
        }

        [Test]
        public void ReleaseChange_WhenChangeAlreadyReleased_Expect0()
        {
            // arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertCoin(25);
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
            VendingMachine vendingMachine = new VendingMachine();
            // act
            Product product = vendingMachine.BuyProduct();
            // assert
            Assert.IsNull(product);
        }

        [Test]
        public void BuyProduct_When50cIsInserted_ExpectProduct()
        {
            // arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertCoin(25);
            vendingMachine.InsertCoin(25);
            // act
            Product product = vendingMachine.BuyProduct();
            // assert
            Assert.IsNotNull(product);
        }


    }
}
