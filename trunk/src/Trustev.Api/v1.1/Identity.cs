using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Services.Identity;

namespace Trustev.Api.v1_1
{
    public class Identity
    {
        private IdentityServiceClient service;

        public Identity()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (IdentityServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Identity);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        public void UpdateCustomer(UpdateCustomerRequest request, Guid id)
        {
            service.UpdateCustomer(request, id.ToString());
        }
    }
}
