using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Trustev.Api.v1.Helpers
{
    public class AuthenticationHelper
    {
        #region singleton

        private static readonly AuthenticationHelper _instance = new AuthenticationHelper();

        private AuthenticationHelper()
        {
        }

        public static AuthenticationHelper Instance
        {
            get { return _instance; }
        }

        #endregion

        public String PasswordHashHelper(string password, string sharedsecret, DateTime timestamp)
        {
            return Create256Hash(Create256Hash(timestamp.ToString("yyyyMMddHHmmss") + "." + password) + "." + sharedsecret);           
        }


        public String Sha256HashHelper(string username, string sharedsecret, DateTime timestamp)
        {
            return Create256Hash(Create256Hash(timestamp.ToString("yyyyMMddHHmmss") + "." + username) + "." + sharedsecret);
        }
        
 
        public String Create256Hash(string toHash)
        {
            HashAlgorithm sha = new SHA256Managed();

            byte[] tohashBytes = Encoding.UTF8.GetBytes(toHash);
            byte[] resultBytes = sha.ComputeHash(tohashBytes);

            return HexEncode(resultBytes);
        }

        private String HexEncode(byte[] data)
        {
            string result = "";
            foreach (byte b in data)
            {
                result += b.ToString("X2");
            }
            result = result.ToLower();

            return (result);
        
        }
        

    }

}
