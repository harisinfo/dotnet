using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1.Services.Social;

namespace Trustev.Api.v1_1
{
    public class Social
    {
        private SocialServiceClient service;

        /// <summary>
        /// Create a new instance of the Profile class
        /// </summary>
        public Social()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Social);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        /// <summary>
        /// Create a new identity with a social profile attached
        /// </summary>
        public void AddProfile(AddProfileRequest request)
        {            
            service.AddProfile(request);
        }

        /// <summary>
        /// Update a social profile associated with an existing identity, or add a new social profile to an existing identity
        /// </summary>
        public void UpdateProfile(UpdateProfileRequest request, ConstantsSocialNetworkType type, String id)
        {
            service.UpdateProfile(request, type.ToString(), id);
        }

        /// <summary>
        /// Remove a social profile from an existing identity
        /// </summary>
        public void DeleteProfile(ConstantsSocialNetworkType type, String id)
        {
            service.DeleteProfile(type.ToString(), id);
        }

    }

}


   

 