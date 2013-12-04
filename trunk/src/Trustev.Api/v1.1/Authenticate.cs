using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Net.Security;
using System.Diagnostics;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Models;
using Trustev.Api.v1_1.Services.Authentication;

namespace Trustev.Api.v1_1
{
    public class Authenticate
    {
        AuthenticationServiceClient service;
        AuthenticationServiceClient serviceNoAuth;        

        /// <summary>
        /// Create a new instance of the Authenticate class
        /// </summary>
        public Authenticate()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();

            service = (AuthenticationServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);
            serviceNoAuth = (AuthenticationServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

            service.Endpoint.Behaviors.Add(behaviour);
        }

        /// <summary>
        /// Create a new instance of the Authenticate class with username, password and secret specified
        /// </summary>
        public Authenticate(String username, String password, String secret)
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();

            service = (AuthenticationServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);
            serviceNoAuth = (AuthenticationServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

            service.Endpoint.Behaviors.Add(behaviour);

            AuthenticationToken.Instance.UserName = username;
            AuthenticationToken.Instance.Password = password;
            AuthenticationToken.Instance.Secret = secret;
            AuthenticationToken.Instance.Timestamp = DateTime.UtcNow;
        }

        /// <summary>
        /// Create a new authentication token
        /// </summary>
        public CreateTokenResponse GetToken()
        {
            string passwordHash = AuthenticationHelper.Instance.PasswordHashHelper(AuthenticationToken.Instance.Password, AuthenticationToken.Instance.Secret, AuthenticationToken.Instance.Timestamp);
            string sha256Hash = AuthenticationHelper.Instance.Sha256HashHelper(AuthenticationToken.Instance.UserName, AuthenticationToken.Instance.Secret, AuthenticationToken.Instance.Timestamp);

            CreateTokenResponse response = serviceNoAuth.CreateToken(new CreateTokenRequest
            {
                UserName = AuthenticationToken.Instance.UserName,
                Password = passwordHash,
                Sha256Hash = sha256Hash,
                Timestamp = AuthenticationToken.Instance.Timestamp
            });

            AuthenticationToken.Instance.Token = response.Token.APIToken;
            AuthenticationToken.Instance.TokenExpiry = response.Token.ExpireAt;

            return response;
        }

        /// <summary>
        /// Authenticate a user based upon a username and password combination
        /// </summary>
        public AuthenticateUserResponse AuthenticateUser(AuthenticateUserRequest request)
        {
            return service.AuthenticateUser(request);
        }

        /// <summary>
        /// Begin a new User Password Reset process
        /// </summary>
        public void ResetUserPassword(ResetUserPasswordRequest request)
        {
            service.ResetUserPassword(request);
        }
    }
}







