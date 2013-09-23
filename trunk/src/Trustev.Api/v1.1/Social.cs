using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Services.Social;

namespace Trustev.Api.v1_1
{
    public class Social : Authenticate
    {
        public void AddProfile(AddProfileRequest request)
        {
            SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Social);
            
            service.AddProfile(request);
        }

        public void UpdateProfile(UpdateProfileRequest request)
        {
            SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Social);


            service.UpdateProfile(request, "0", "222");
        }

        public void DeleteProfile()
        {
            SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Social);
            service.DeleteProfile("0", "999");
        }

    }

}


   

 