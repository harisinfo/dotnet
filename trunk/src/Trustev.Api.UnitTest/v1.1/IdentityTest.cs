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
using Trustev.Api.v1_1.Services.Identity;

namespace Trustev.Api.UnitTest.v1_1
{
    public class IdentityTest
    {
        private Identity service;

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
            service = new Identity();
        }

        [Test]
        public void UpdateCustomerPass()
        {
            UpdateCustomerRequest request = new UpdateCustomerRequest();
            Guid id = new Guid("EF9AE756-D753-4680-837C-A158011A0734");

            request.FirstName = "Chris";
            request.LastName = "Kennedy";
            request.Email = new List<Email>();
            request.Email.Add(new Email() { EmailAddress = "chris.kennedy@nottrustev.com", IsDefault = true });
            request.Address = new List<Address>();
            request.Address.Add(new Trustev.Api.v1_1.Services.Identity.Address() { Address1 = "Trustev", Address2 = "Blackrock", City = "Cork", PostalCode = "Cork", State = "Cork", CountryIsoA2Code = "IE", IsDefault = true, Type = Trustev.Api.v1_1.Services.Identity.ConstantsAddressType.Billing });
            request.Address.Add(new Trustev.Api.v1_1.Services.Identity.Address() { Address1 = "Trustev", Address2 = "Blackrock", City = "Cork", PostalCode = "Cork", State = "Cork", CountryIsoA2Code = "IE", IsDefault = true, Type = Trustev.Api.v1_1.Services.Identity.ConstantsAddressType.Delivery });
            request.PhoneNumber = "+353871234567";

            service.UpdateCustomer(request, id);
        }
    }
}
