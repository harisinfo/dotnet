using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1_1;
using Trustev.Api.v1_1.Services.Social;

namespace Trustev.Api.UnitTest.v1_1
{
    [TestFixture]
    public class SocialTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private string _Id;
        private string _shorttermaccesstoken;
        private string _longtermaccesstoken;
        private DateTime _shortternaccesstokenexpiry;
        private DateTime _longternaccesstokenexpiry;
        private string _secret;

        [SetUp]
        public void Setup()
        {
            _username = "testtrustev";
            _password = "6af92077e0f325a0df39f694cfecc113";
            _sharedsecret = "5160574c3159333093f1c7bf92756366";
        }

        [Test]
        public void AddProfileTest()
        {

            Trustev.Api.v1_1.Services.Social.SocialNetwork socialNetwork = new Trustev.Api.v1_1.Services.Social.SocialNetwork
            {
                Id = "2341",
                Type = Trustev.Api.v1_1.Services.Social.ConstantsSocialNetworkType.Facebook,
                LongTermAccessToken = "fjdjjnvf",
                Secret = "secret",
                ShortTermAccessToken = "ffvdfdfdf",
                LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30),
                ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)
            };

            List<Trustev.Api.v1_1.Services.Social.SocialNetwork> socialNetworks = new List<Trustev.Api.v1_1.Services.Social.SocialNetwork>();
            socialNetworks.Add(socialNetwork);

        }

        [Test]
        public void UpdateProfileTest()
        {
       
        }

        [Test]
        public void DeleteProfileTest()
        {
            

 
        }
    }
}
