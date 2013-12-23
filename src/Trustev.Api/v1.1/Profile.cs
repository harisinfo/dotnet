using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1.Services.Profile;

namespace Trustev.Api.v1_1
{
	public class Profile
	{
        private ProfileServiceClient service;

        /// <summary>
        /// Create a new instance of the Profile class
        /// </summary>
        public Profile()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (ProfileServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Profile);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        /// <summary>
        /// Create a new retail profile based upon an existing Identity
        /// </summary>
        public CreateRetailProfileResponse CreateRetailProfileByIdentity(CreateRetailProfileRequest request, Guid id)
        {
            return service.CreateRetailProfileByIdentity(request, id.ToString());
        }

        /// <summary>
        /// Get a Trustev Profile based upon a specified Transaction Number or Transaction Id
        /// </summary>
        public GetProfileResponse GetProfileByTransaction(String id)
        {
            return service.GetProfileByTransaction(id);
        }

        /// <summary>
        /// Retrieve a Retail Profile based upon the Id returned by a call to CreateRetailProfileByIdentity
        /// </summary>
        public GetRetailProfileResponse GetRetailProfile(Guid id)
        {
            return service.GetRetailProfile(id.ToString());
        }
	}
}
