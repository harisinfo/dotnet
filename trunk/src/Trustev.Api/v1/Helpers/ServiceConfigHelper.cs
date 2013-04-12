using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

using Trustev.Api.v1.Services.Authentication;
using Trustev.Api.v1.Services.Social;
using Trustev.Api.v1.Services.Transaction;

namespace Trustev.Api.v1.Helpers
{
    public class ServiceConfigHelper
    {
        private String TrustevApiBaseAddress { get; set; }

        #region singleton

        private static readonly ServiceConfigHelper _instance = new ServiceConfigHelper();

        private ServiceConfigHelper()
        {
            TrustevApiBaseAddress = "https://api.trustev.com/v1/";
        }

        public static ServiceConfigHelper Instance
        {
            get { return _instance; }
        }

        #endregion


        public object GetService(Constants.ServiceType serviceType)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address;

            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            switch (serviceType)
            {
                case Constants.ServiceType.Authentication:
                    address = new EndpointAddress(String.Format("{0}/AuthenticationService.svc/soap", TrustevApiBaseAddress));
                    return new AuthenticationServiceClient(binding, address);
                case Constants.ServiceType.Social:
                    address = new EndpointAddress(String.Format("{0}/SocialService.svc/soap", TrustevApiBaseAddress));
                    return new SocialServiceClient(binding, address);
                case Constants.ServiceType.Transaction:
                    address = new EndpointAddress(String.Format("{0}/TransactionService.svc/soap", TrustevApiBaseAddress));
                    return new TransactionServiceClient(binding, address);
                    
                default:
                    throw new Exception("Could not build a valid API Base URL and Binding");
            }
        }
    }
}
