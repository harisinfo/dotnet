using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using Trustev.Api.v1_1.Services.Transaction;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1;

namespace Trustev.Api.UnitTest.v1_1
{
    [TestFixture]
    public class TransactionTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private String _transactionNumber;
        private Transaction _service;

        [TestFixtureSetUp]
        public void Setup()
        {
            _username = System.Configuration.ConfigurationManager.AppSettings["TrustevApiUsername"];
            _password = System.Configuration.ConfigurationManager.AppSettings["TrustevApiPassword"];
            _sharedsecret = System.Configuration.ConfigurationManager.AppSettings["TrustevApiSecret"];
            _transactionNumber = DateTime.UtcNow.ToString("yyyyMMddmmHHss");

            _service = new Transaction();
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
                FirstName = "Paul",
                LastName = "Smith",
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
                FirstName = "Paul",
                LastName = "Smith",
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
                TotalItemValue = 12.120M,
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
                TotalTax = 2.10m,
                TotalTransactionValue = 12.10M
            };
            request.TransactionNumber = _transactionNumber;

            _service.AddTransaction(request);
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
                FirstName = "Paul",
                LastName = "Smith",
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
                FirstName = "Paul",
                LastName = "Smith",
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
                TotalItemValue = 12.10M,
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
                TotalTax = 2.10m,
                TotalTransactionValue = 12.10M
            };

            _service.UpdateTransaction(request, _transactionNumber);
        }

        [Test]
        public void AddTransactionStatusTest()
        {
            AddTransactionStatusRequest request = new AddTransactionStatusRequest();
            request.Comment = "Unit Test";
            request.Reason = ConstantsOrderStatusReason.System;
            request.Status = ConstantsOrderStatus.Completed;

            _service.AddTransactionStatus(request, _transactionNumber);
        }

        [Test]
        public void AddTransactionBINTest()
        {
            AddTransactionBINRequest request = new AddTransactionBINRequest();
            request.BINNumber = "123456";

            _service.AddTransactionBIN(request, _transactionNumber);
        }
    }
}
