using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Trustev.Api.v1.Helpers;
using Trustev.Api.v1.Services.Social;



namespace Trustev.Api.v1
{
    public class Social
    {

       public AddProfileResponse AddProfile(AddProfileRequest request)
       {
           SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

           return service.AddProfile(request);
        }


        public  UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
       {
           SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

           return service.UpdateProfile(request);
       }


       public DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
       {
           SocialServiceClient service = (SocialServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

           return service.DeleteProfile(request);
       }




       
    }

}
