using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1;
using Trustev.Api.v1.Services.Authentication;

namespace Trustev.Api.UnitTest.v1
{

    [TestFixture]
    public class AuthenticateTest
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
        public void GetTokenTest()
        {
            Authenticate service = new Authenticate(_username, _password, _sharedsecret);
            AuthResponse response = service.GetToken();

            Debug.Write(String.Format("Response Code: {0}", response.Code));
            Debug.Write(String.Format("Response Message: {0}", response.Message));
            Debug.Write(String.Format("Token: {0}", response.Token.Token));

            Assert.AreEqual(response.Code, 200);
        }

        [Test]
        public void GetToken401Test()
        {
            Authenticate service = new Authenticate(String.Empty, _password, _sharedsecret);
            AuthResponse response = service.GetToken();

            Debug.Write(String.Format("Response Code: {0}", response.Code));
            Debug.Write(String.Format("Response Message: {0}", response.Message));
            Debug.Write(String.Format("Token: {0}", response.Token.Token));

            Assert.AreEqual(response.Code, 401);
        }

    }
}
