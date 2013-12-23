using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Services.Authentication;

namespace Trustev.Api.UnitTest.v1_1.Helpers
{

    [TestFixture]
    public class AuthenticationHelperTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private DateTime _timestamp;

        [SetUp]
        public void Setup()
        {
            _username = System.Configuration.ConfigurationManager.AppSettings["TrustevApiUsername"];
            _password = System.Configuration.ConfigurationManager.AppSettings["TrustevApiPassword"];
            _sharedsecret = System.Configuration.ConfigurationManager.AppSettings["TrustevApiSecret"];
            _timestamp = DateTime.UtcNow;

        }

        [Test]
        public void Create256HashTest()
        {
            String result = AuthenticationHelper.Instance.Create256Hash(_username);
            Assert.IsNotNullOrEmpty(result);
        }

        [Test]
        public void Create256HashTestMatchedValue()
        {
            String result = AuthenticationHelper.Instance.Create256Hash(_username);
            Assert.IsNotNullOrEmpty(result);
        }

        [Test]
        public void PasswordHashHelperTest()
        {
            String result = AuthenticationHelper.Instance.PasswordHashHelper(_password, _sharedsecret, _timestamp);
            Assert.IsNotNullOrEmpty(result);
        }

        [Test]
        public void PasswordHashHelperTestMatchedValue()
        {
            String result = AuthenticationHelper.Instance.PasswordHashHelper(_password, _sharedsecret, _timestamp);
            Assert.IsNotNullOrEmpty(result);
        }

        [Test]
        public void Sha256HashHelperTest()
        {
            String result = AuthenticationHelper.Instance.Sha256HashHelper(_username, _sharedsecret, _timestamp);
            Assert.IsNotNullOrEmpty(result);

        }


    }


}




    
