using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using NUnit.Framework;

using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Services.Authentication;

namespace Trustev.Api.UnitTest.v1_1.Helpers
{

    [TestFixture]
    public class ServiceConfigHelperTest
    {

        [Test]
        public void GetAuthenticationServiceNotNullPass()
        {
            object response = ServiceConfigHelper.Instance.GetService(Api.v1_1.Models.Constants.ServiceType.Authentication);
            
            Assert.IsNotNull(response);
        }

        [Test]
        public void GetAuthenticationServiceTypePass()
        {
            object response = ServiceConfigHelper.Instance.GetService(Api.v1_1.Models.Constants.ServiceType.Authentication);

            Assert.IsInstanceOf<AuthenticationServiceClient>(response);
        }


    }

}