using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Serialization;
using System.Text;
using NUnit.Framework;

using Trustev.Api.v1_1;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1.Services.Authentication;

namespace Trustev.Api.UnitTest.v1_1
{
    [TestFixture]
    public class AuthenticateTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private DateTime _timestamp;
        private Authenticate _service;

        [SetUp]
        public void Setup()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
               delegate(
                   Object sender1,
                   X509Certificate certificate,
                   X509Chain chain,
                   SslPolicyErrors sslPolicyErrors)
               {
                   return true;
               };

            _username = System.Configuration.ConfigurationManager.AppSettings["TrustevApiUsername"];
            _password = System.Configuration.ConfigurationManager.AppSettings["TrustevApiPassword"];
            _sharedsecret = System.Configuration.ConfigurationManager.AppSettings["TrustevApiSecret"];
            _timestamp = DateTime.UtcNow;

            _service = new Authenticate(_username, _password, _sharedsecret);
        }

        [Test]
        public void GetTokenTest()
        {
            CreateTokenResponse response = _service.GetToken();

            Trace.WriteLine(String.Format("Response Code: {0}", response.Code));
            Trace.WriteLine(String.Format("Response Message: {0}", response.Message));
            Trace.WriteLine(String.Format("Token: {0}", response.Token.APIToken));
            Trace.WriteLine(String.Format("Expiry Date: {0}", response.Token.ExpireAt));


            Assert.AreEqual(response.Code, 200);
        }


        [Test]
        public void GetToken401Test()
        {
                Authenticate serviceFail = new Authenticate("fakeUsername", _password, _sharedsecret);
                CreateTokenResponse response = serviceFail.GetToken();

                Debug.Write(String.Format("Response Code: {0}", response.Code));
                Debug.Write(String.Format("Response Message: {0}", response.Message));
                Debug.Write(String.Format("Token: {0}", response.Token.APIToken));


                Assert.AreEqual(response.Code, 401);
        }

        [Test]
        public void AuthenticateUserPass()
        {
            AuthenticateUserResponse res = _service.AuthenticateUser(new AuthenticateUserRequest() { UserName = "ChrisKennedy", Password = "cJR9Aetx" });
            Assert.NotNull(res);
        }

        [Test]
        public void ResetUserPasswordPass()
        {
            List<ConstantsCommunicationType> type = new List<ConstantsCommunicationType>();
            type.Add(ConstantsCommunicationType.Email);

            _service.ResetUserPassword(new ResetUserPasswordRequest() { Email = "chris.kennedy@trustev.com", DeliveryMethod = type });
        }
    }
}
