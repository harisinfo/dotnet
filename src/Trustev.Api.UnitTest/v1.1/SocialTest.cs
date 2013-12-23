using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1_1;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1.Services.Social;

namespace Trustev.Api.UnitTest.v1_1
{
    [TestFixture]
    public class SocialTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private string _socialNetworkId;
        private Social _service;

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

            _socialNetworkId = DateTime.UtcNow.ToString("yyyyMMddmmHHss");

            _service = new Social();
        }

        [Test]
        public void AddProfileTest()
        {
            AddProfileRequest request = new AddProfileRequest();

            request.SocialNetworks = new List<SocialNetwork>();

            SocialNetwork socialNetwork = new SocialNetwork
            {
                Id = _socialNetworkId,
                Type = Trustev.Api.v1_1.Services.Social.ConstantsSocialNetworkType.Facebook,
                LongTermAccessToken = "abc",
                Secret = "secret",
                ShortTermAccessToken = "def",
                LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30),
                ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)
            };

            request.SocialNetworks.Add(socialNetwork);

            _service.AddProfile(request);

        }

        [Test]
        public void UpdateProfileTest()
        {
            UpdateProfileRequest request = new UpdateProfileRequest();

            request.SocialNetworks = new List<SocialNetwork>();

            SocialNetwork socialNetwork = new SocialNetwork
            {
                Id = _socialNetworkId,
                Type = Trustev.Api.v1_1.Services.Social.ConstantsSocialNetworkType.Facebook,
                LongTermAccessToken = "def",
                Secret = "secret",
                ShortTermAccessToken = "abc",
                LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30),
                ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)
            };

            request.SocialNetworks.Add(socialNetwork);

            _service.UpdateProfile(request, ConstantsSocialNetworkType.Facebook, _socialNetworkId);  
        }

        [Test]
        public void DeleteProfileTest()
        {
            _service.DeleteProfile(ConstantsSocialNetworkType.Facebook, _socialNetworkId); 
        }
    }
}
