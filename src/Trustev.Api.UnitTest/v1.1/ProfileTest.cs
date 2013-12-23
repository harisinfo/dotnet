using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1_1;
using Trustev.Api.v1_1.Services.Profile;

namespace Trustev.Api.UnitTest.v1_1
{

    [TestFixture]
    public class ProfileTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private String _transactionNumber;
        private Profile _service;

        [SetUp]
        public void Setup()
        {
            _username = System.Configuration.ConfigurationManager.AppSettings["TrustevApiUsername"];
            _password = System.Configuration.ConfigurationManager.AppSettings["TrustevApiPassword"];
            _sharedsecret = System.Configuration.ConfigurationManager.AppSettings["TrustevApiSecret"];
            _transactionNumber = DateTime.UtcNow.ToString("yyyyMMddmmHHss");

            _service = new Profile();
     
        }

        [Test]
        public void GetProfileTest()
        {
            GetProfileResponse response = _service.GetProfileByTransaction(_transactionNumber);

            Assert.NotNull(response);
        }
    }
}
