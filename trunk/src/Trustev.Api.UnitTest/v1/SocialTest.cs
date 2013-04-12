using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Trustev.Api.v1;
using Trustev.Api.v1.Services.Social;

namespace Trustev.Api.UnitTest.v1
{
    [TestFixture]
    public class SocialTest
    {
        private string _username;
        private string _password;
        private string _sharedsecret;
        private string _Id;
        private string _shorttermaccesstoken;
        private string _longtermaccesstoken;
        private DateTime _shortternaccesstokenexpiry;
        private DateTime _longternaccesstokenexpiry;
        private string _secret;

        [SetUp]

        public void Setup()
        {


            _Id = "id";
            _shorttermaccesstoken = "dvvhbvdbvhdb";
            _longtermaccesstoken = "sdsd4sd84sdv4";
            _shortternaccesstokenexpiry = DateTime.UtcNow.AddHours(2);
            _longternaccesstokenexpiry = DateTime.UtcNow.AddDays(30);
            _secret = "hjfhifhjwehu5";

            _username = "testtrustev";
            _password = "6af92077e0f325a0df39f694cfecc113";
            _sharedsecret = "5160574c3159333093f1c7bf92756366";


            Authenticate service = new Authenticate(_username, _password, _sharedsecret);


        }

        [Test]
        public void AddProfile1()
        {
            try
            {
                {
                    Social socialWrapper = new Social();

                    AddProfileRequest request = new AddProfileRequest();
                    request.UserName = "trustev";
                    List<SocialNetwork> socialNetworks = new List<SocialNetwork>();
                    SocialNetwork socialNetwork = new SocialNetwork { Id = _Id, Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook, LongTermAccessToken = _longtermaccesstoken, Secret = _secret, ShortTermAccessToken = _shorttermaccesstoken, LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2) };
                    socialNetworks.Add(null);
   
                    request.SocialNetworks = socialNetworks.ToArray();
                    AddProfileResponse response = socialWrapper.AddProfile(request);

                    Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
                }
            }
            catch (Exception ex)
            {

            }

        }

        [Test]
        public void AddProfile2()
        {
            try
            {

                Social socialWrapper = new Social();

                AddProfileRequest request = new AddProfileRequest();
                request.UserName = "trustev";
                IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();

                SocialNetwork socialNetwork1 = new SocialNetwork { Id = "0", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)};
                SocialNetwork socialNetwork2 = new SocialNetwork { Id = "1", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Twitter, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)};
                SocialNetwork socialNetwork3 = new SocialNetwork { Id = "2", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.LinkedIn, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)};
                SocialNetwork socialNetwork4 = new SocialNetwork { Id = "3", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Trustev, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2)};


                socialNetworks.Add(socialNetwork1);
                socialNetworks.Add(socialNetwork2);
                socialNetworks.Add(socialNetwork3);

                request.SocialNetworks = socialNetworks.ToArray();
                AddProfileResponse response = socialWrapper.AddProfile(request);

                Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
            }
            catch (Exception ex)
            {

            }
                
        }


        [Test]
        public void UpdateProfile()
            
        {
            

            Social socialWrapper = new Social();

            UpdateProfileRequest request = new UpdateProfileRequest();

            request.UserName = "testtrustev";
            request.Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook;
            request.Id = "2";
            SocialNetwork socialNetwork1 = new SocialNetwork { Id = "2", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Twitter, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2) };

            IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();
            socialNetworks.Add(socialNetwork1);
            request.SocialNetworks = socialNetworks.ToArray();

            UpdateProfileResponse response = socialWrapper.UpdateProfile(request);
            Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
        }



        [Test]
        public void DeleteProfile()
        {
            Social socialWrapper = new Social();


            DeleteProfileRequest request = new DeleteProfileRequest();

            request.UserName = "trustev";

            SocialNetwork socialNetwork4 = new SocialNetwork { Id = "3", Type =Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook };

            IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();
            socialNetworks.Remove(socialNetwork4);

            request.SocialNetworks = socialNetworks.ToArray();

            DeleteProfileResponse response = socialWrapper.DeleteProfile(request);
            Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
        }
    }
}
