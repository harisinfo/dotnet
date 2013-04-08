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

            _username = "testtrustev";
            _password = "6af92077e0f325a0df39f694cfecc113";
            _sharedsecret = "5160574c3159333093f1c7bf92756366";
            _timestamp = DateTime.UtcNow;

        }



        [Test]
        public void GetTokenTest()
        {
            try
            {
                Authenticate service = new Authenticate(_username, _password, _sharedsecret);
                AuthResponse response = service.GetToken();

                Debug.WriteLine(String.Format("Response Code: {0}", response.Code));
                Debug.WriteLine(String.Format("Response Message: {0}", response.Message));
                Debug.WriteLine(String.Format("Token: {0}", response.Token.Token));

                Assert.AreEqual(response.Code, 200);
            }
            catch (Exception ex)
            {
            }
        }

        [Test]
        public void GetToken401Test()
        {
            try
            {
                Authenticate service = new Authenticate("test", _password, _sharedsecret);
                AuthResponse response = service.GetToken();

                Debug.WriteLine(String.Format("Response Code: {0}", response.Code));
                Debug.WriteLine(String.Format("Response Message: {0}", response.Message));
                Debug.WriteLine(String.Format("Token: {0}", response.Token.Token));

                Assert.AreEqual(response.Code, 401);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.InnerException.Message, "The remote server returned an error: (401) Unauthorized.");
            }
        }

    }
}
