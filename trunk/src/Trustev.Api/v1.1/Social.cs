using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Services.Social;

namespace Trustev.Api.v1_1
{
    public class Social
    {
        private SocialServiceClient service;

        public Social()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Social);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        public void AddProfile(AddProfileRequest request)
        {            
            service.AddProfile(request);
        }

        public void UpdateProfile(UpdateProfileRequest request, ConstantsSocialNetworkType type, String id)
        {
            service.UpdateProfile(request, type.ToString(), id);
        }

        public void DeleteProfile(ConstantsSocialNetworkType type, String id)
        {
            service.DeleteProfile(type.ToString(), id);
        }

    }

}


   

 