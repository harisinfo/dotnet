using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1.Helpers;
using Trustev.Api.v1.Services.Authentication;

namespace Trustev.Api.UnitTest.v1.Helpers
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

            _username = "trustev";
            _password = "trustev123";
            _sharedsecret = "c37e5b4b13954cd5a13bf37155427577";
            _timestamp = DateTime.UtcNow;

        }

        [Test]
        public void Create256HashTest()
        {
            String result = AuthenticationHelper.Instance.Create256Hash(_username);
            Console.WriteLine(result);
            Assert.IsNotNullOrEmpty(result);
        }

        [Test]
        public void Create256HashTestMatchedValue()
        {
            String result = AuthenticationHelper.Instance.Create256Hash(_username);

            Debug.Write("Test");

            Assert.AreEqual(_username, "trustev");
        }

        [Test]
        public void PasswordHashHelperTest()
        {
            String result = AuthenticationHelper.Instance.PasswordHashHelper(_password, _sharedsecret, _timestamp);
            Assert.IsNotNullOrEmpty(result);
            Debug.Write("Test");
            Console.WriteLine(result);
        }

        [Test]
        public void PasswordHashHelperTestMatchedValue()
        {
            String result = AuthenticationHelper.Instance.PasswordHashHelper(_password, _sharedsecret, _timestamp);

            Debug.Write("Test");

            Assert.AreEqual(_password, "trustev123");
        }

        [Test]

        public void Sha256HashHelperTest()
        {

            String result = AuthenticationHelper.Instance.Sha256HashHelper(_username, _sharedsecret, _timestamp);
            Assert.IsNotNullOrEmpty(result);
            Debug.Write("Test");
            Console.WriteLine(result);

        }


    }


}




    
