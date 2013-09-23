using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trustev.Api.v1_1.Services.Profile;
using Trustev.Api.v1_1.Helpers;

namespace Trustev.Api.v1_1
{
	public class Profile
	{

        public void GetProfile(GetProfileResponse response)
        {
            ProfileServiceClient service = (ProfileServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);
            service.GetProfile("1", "999", "10");
        }
	}
}
