using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using Trustev.Api.v1.Helpers;

namespace Trustev.Libraries.Api.UnitTest.v1.Helpers
{

    [TestFixture]
    public class AuthenticationHelperTest

    {
        private string _username;
        private DateTime _timestamp;
        
        [SetUp]
        public void Setup()
        {
           
           _username = "trustev";
           _timestamp = DateTime.UtcNow;

        }

        [Test]
        public void Create256HashTest()
        {
            String result = AuthenticationHelper.Instance.Create256Hash(_username);

            
            Assert.IsNotNullOrEmpty(result);
        }
            
}
    }
