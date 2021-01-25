using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetailApp.Domain.Models;

namespace RetailApp.Tests
{
    [TestClass]
    public class ReceiptModel_Tests
    {

        public ReceiptModel CreateTestModel()
        {
            return new ReceiptModel(
               1, new DateTime(), 123, "Charles Barkley",
               new AddressModel(), 12334, 9, "Golden Shoes",
               210.50m, 2);
        }

        [TestMethod]
        [DescriptionAttribute("A new reciept is created with correct name")]
        public void CanCreateReceipt()
        {
            var testModel = CreateTestModel();

            Assert.AreEqual(testModel.CustomerName, "Charles Barkley");
        }

        [TestMethod]
        [DescriptionAttribute("A ReceiptNumber less than zero throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReceiptNumberLessThanZeroThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.ReceiptNumber = 0;
        }

        [TestMethod]
        [DescriptionAttribute("A ReceiptNumber in range entry is ok")]
        public void RecieptNumberAboveZeroIsOk()
        {

            var testModel = CreateTestModel();

            testModel.ReceiptNumber = 2;

            Assert.AreEqual(testModel.ReceiptNumber, 2);
        }

        [TestMethod]
        [DescriptionAttribute("A CustomerNumber below zero throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CustomerNumberLessThanZeroThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.CustomerNumber = 0;
        }

        [TestMethod]
        [DescriptionAttribute("A CustomerNumber in range entry is ok")]
        public void CustomerNumberAboveZeroIsOk()
        {

            var testModel = CreateTestModel();

            testModel.CustomerNumber = 2;

            Assert.AreEqual(testModel.CustomerNumber, 2);
        }

        [TestMethod]
        [DescriptionAttribute("An ItemNumber below zero throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemNumberLessThanZeroThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.ItemNumber = 0;
        }

        [TestMethod]
        [DescriptionAttribute("An ItemNumber above 9999 throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemNumberAboveMaxThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.ItemNumber = 9999999;
        }

        [TestMethod]
        [DescriptionAttribute("An ItemNumber in range entry is ok")]
        public void ItemNumberAboveZeroIsOk()
        {

            var testModel = CreateTestModel();

            testModel.ItemNumber = 2;

            Assert.AreEqual(testModel.ItemNumber, 2);
        }

        [TestMethod]
        [DescriptionAttribute("A UnitPrice above 9999 throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UnitPriceAboveMaxThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.UnitPrice = 9999999;
        }

        [TestMethod]
        [DescriptionAttribute("A UnitPrice less than zero throws an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UnitUnitLessThanZeroThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.UnitPrice = 0;
        }

        [TestMethod]
        [DescriptionAttribute("A UnitPrice in range entry is ok")]
        public void UnitPriceInRangeIsOk()
        {

            var testModel = CreateTestModel();

            testModel.UnitPrice = 2;

            Assert.AreEqual(testModel.UnitPrice, 2);
        }

        [TestMethod]
        [DescriptionAttribute("A QuantityPurchased below zero thows an exception")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuantityPurchasedLessThanZeroThrowsException()
        {

            var testModel = CreateTestModel();

            testModel.QuantityPurchased = 0;
        }

        [TestMethod]
        [DescriptionAttribute("An in range QuantityPurchased entry is OK")]
        public void QuantityPurchasedInRangeIsOk()
        {

            var testModel = CreateTestModel();

            testModel.QuantityPurchased = 2;

            Assert.AreEqual(testModel.QuantityPurchased, 2);
        }

    }
}
