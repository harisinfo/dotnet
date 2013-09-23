using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1_1;
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

        [SetUp]
        public void Setup()
        {

            _username = "testtrustev";
            _password = "6af92077e0f325a0df39f694cfecc113";
            _sharedsecret = "5160574c3159333093f1c7bf92756366";
            _timestamp = DateTime.UtcNow;

        }

        [Test]
        public void GetTokenTest()
        {

            Authenticate service = new Authenticate(_username, _password, _sharedsecret);
            CreateTokenResponse response = service.GetToken();

            Trace.WriteLine(String.Format("Response Code: {0}", response.Code));
            Trace.WriteLine(String.Format("Response Message: {0}", response.Message));
            Trace.WriteLine(String.Format("Token: {0}", response.Token.APIToken));
            Trace.WriteLine(String.Format("Expiry Date: {0}", response.Token.ExpireAt));


            Assert.AreEqual(response.Code, 200);
        }


        [Test]
        public void GetToken401Test()
        {

           
                Authenticate service = new Authenticate("fakeUsername", _password, _sharedsecret);
                CreateTokenResponse response = service.GetToken();

                Debug.Write(String.Format("Response Code: {0}", response.Code));
                Debug.Write(String.Format("Response Message: {0}", response.Message));
                Debug.Write(String.Format("Token: {0}", response.Token.APIToken));


                Assert.AreEqual(response.Code, 401);

        }


    }
}
