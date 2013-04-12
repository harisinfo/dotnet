﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Net.Security;
using Trustev.Api.v1.Helpers;
using Trustev.Api.v1.Services.Authentication;
using System.Diagnostics;

namespace Trustev.Api.v1
{
    public class Authenticate
    {
        public String UserName { get; set; }
        private String Password { get; set; }
        private String Secret { get; set; }
        private DateTime Timestamp { get; set; }
        private String _token;
        public String TransactionNumber { get; set; }
        public String Token
        {
            get
            {
                ValidateToken();
                return _token;
            }
            set
            {
                _token = value;
            }
        }
        public DateTime TokenExpiry {get;set;}

        protected Authenticate()
        {
        }

        public Authenticate(String username, String password, String secret)
        {
            UserName = username;
            Password = password;
            Secret = secret;
            Timestamp = DateTime.UtcNow;
        }

        public AuthResponse GetToken()
        {
            AuthenticationServiceClient service = (AuthenticationServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Authentication);

            string passwordHash = AuthenticationHelper.Instance.PasswordHashHelper(Password, Secret, Timestamp);
            string sha256Hash = AuthenticationHelper.Instance.Sha256HashHelper(UserName, Secret, Timestamp);
            
            AuthResponse response = service.GetToken(new SimpleLoginRequest
            {
                UserName = UserName,
                Password = passwordHash,
                Sha256Hash = sha256Hash,
                Timestamp = Timestamp
            });

            Token = response.Token.Token;
            TokenExpiry = response.Token.ExpireAt;

            return response;
        }

        private void ValidateToken()
        {

            if (TokenExpiry < DateTime.UtcNow)
            {
                Debug.Write("Error: ValidateToken:Invalid token.");

                GetToken();

            }

        }
    }


}







