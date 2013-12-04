using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trustev.Api.v1_1;

namespace Trustev.Api.v1_1.Models
{
    public class AuthenticationToken : Authenticate
    {
        #region singleton

        private static readonly AuthenticationToken _instance = new AuthenticationToken();

        private AuthenticationToken()
        {
        }

        public static AuthenticationToken Instance
        {
            get { return _instance; }
        }

        #endregion

        private String _token;

        public String Token 
        {
            get
            {
                if (TokenExpiry <= DateTime.UtcNow)
                {
                    GetToken();
                }

                return _token;
            }
            set
            {
                _token = value;
            }
        }
        public DateTime TokenExpiry { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Secret { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
