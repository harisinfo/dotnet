using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using Trustev.Api.v1_1.Services.Transaction;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1;

namespace Social.Verify.UnitTest.API.v1_1
{
    [TestFixture]
    public class TransactionServiceTest
    {
        private String transactionNumber;

        [TestFixtureSetUp]
        public void Setup()
        {

            transactionNumber = DateTime.UtcNow.ToString("yyyyMMddmmHHss");
        }

        [Test]
        public void AddTransactionTest()
        {

 
            AddTransactionRequest request = new AddTransactionRequest();
            List<Address> address = new List<Address>();
            List<TransactionItem> items = new List<TransactionItem>();

            address.Add(new Address()
            {
                Address1 = "Trustev",
                Address2 = "Heritage Business Park",
                Address3 = "Bessboro Road",
                City = "Cork",
                CountryIsoA2Code = "IE",
                FirstName = "David",
                LastName = "Devane",
                PostalCode = "CORK",
                State = "CORK",
                Type = Trustev.Api.v1_1.Services.Transaction.ConstantsAddressType.Billing
            });

            address.Add(new Address()
            {
                Address1 = "Trustev",
                Address2 = "Heritage Business Park",
                Address3 = "Bessboro Road",
                City = "Cork",
                CountryIsoA2Code = "IE",
                FirstName = "David",
                LastName = "Devane",
                PostalCode = "CORK",
                State = "CORK",
                Type = Trustev.Api.v1_1.Services.Transaction.ConstantsAddressType.Delivery
            });

            items.Add(new TransactionItem()
            {
                Currency = "EUR",
                ImageURL = "https://www.trustev.com/Images/trustev-logo.png",
                Name = "Trustev Voucher",
                Quantity = 1,
                TotalBeforeTax = 10,
                TotalDiscount = 0,
                TotalTax = 2.10M,
                URL = "https://www.trustev.com"
            });

            request.SessionId = Guid.Parse("29b7d597-25f3-475b-afd9-fb3319deb653");
            request.SocialNetwork = null;
            request.TransactionData = new TransactionData()
            {
                Address = address,
                Currency = "EUR",
                Item = items,
                Timestamp = DateTime.UtcNow,
                TotalBeforeTax = 10,
                TotalDelivery = 0,
                TotalDiscount = 0,
                TotalTax = 2.10m
            };
        }

        [Test]
        public void UpdateTransactionTest()
        {
            UpdateTransactionRequest request = new UpdateTransactionRequest();
            List<Address> address = new List<Address>();
            List<TransactionItem> items = new List<TransactionItem>();

            address.Add(new Address()
            {
                Address1 = "Trustev",
                Address2 = "Heritage Business Park",
                Address3 = "Bessboro Road",
                City = "Cork",
                CountryIsoA2Code = "IE",
                FirstName = "David",
                LastName = "Devane",
                PostalCode = "CORK",
                State = "CORK",
                Type = Trustev.Api.v1_1.Services.Transaction.ConstantsAddressType.Billing
            });

            address.Add(new Address()
            {
                Address1 = "Trustev",
                Address2 = "Heritage Business Park",
                Address3 = "Bessboro Road",
                City = "Cork",
                CountryIsoA2Code = "IE",
                FirstName = "David",
                LastName = "Devane",
                PostalCode = "CORK",
                State = "CORK",
                Type = Trustev.Api.v1_1.Services.Transaction.ConstantsAddressType.Delivery
            });

            items.Add(new TransactionItem()
            {
                Currency = "EUR",
                ImageURL = "https://www.trustev.com/Images/trustev-logo.png",
                Name = "Trustev Voucher",
                Quantity = 1,
                TotalBeforeTax = 10,
                TotalDiscount = 0,
                TotalTax = 2.10M,
                URL = "https://www.trustev.com"
            });

            request.SessionId = Guid.Parse("29b7d597-25f3-475b-afd9-fb3319deb653");
            request.SocialNetwork = null;
            request.TransactionData = new TransactionData()
            {
                Address = address,
                Currency = "EUR",
                Item = items,
                Timestamp = DateTime.UtcNow,
                TotalBeforeTax = 10,
                TotalDelivery = 0,
                TotalDiscount = 0,
                TotalTax = 2.10m
            };
        }

        [Test]
        public void AddTransactionStatusTest(AddTransactionStatusRequest request)
        {
            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);

            service.AddTransactionStatus(request, "343");
        }

        [Test]
        public void AddTransactionBINTest()
        {
            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);
            AddTransactionBINRequest request = new AddTransactionBINRequest()
            {
                BINNumber = "123456"
            };
        }
    }
}
