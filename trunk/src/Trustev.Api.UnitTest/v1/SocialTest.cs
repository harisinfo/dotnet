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
private string _Id;
private string _shorttermaccesstoken;
private string _longtermaccesstoken;
private DateTime _shortternaccesstokenexpiry;
private DateTime _longternaccesstokenexpiry;
private string _secret;

[SetUp]
public void Setup()
{

    _Id = "12345";
    _shorttermaccesstoken = "dvvhbvdbvhdb";
    _longtermaccesstoken = "sdsd4sd84sdv4";
    _shortternaccesstokenexpiry = DateTime.UtcNow.AddHours(2);
    _longternaccesstokenexpiry = DateTime.UtcNow.AddDays(30);
    _secret = "hjfhifhjwehu5";

}



[Test]

public void AddProfile1()
{
    try
    {
        {
            AddProfileRequest request = new AddProfileRequest();
            request.UserName = "trustev";
            IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();
            SocialNetwork socialNetwork = new SocialNetwork { Id = "1", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2) };
            socialNetworks.Add(null);
            request.SocialNetworks = socialNetworks;
            AddProfileResponse response = _socialService.AddProfile(request);

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

        request.SocialNetworks = socialNetworks;
        AddProfileResponse response = _social.AddProfile(request);

        Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
    }

    catch (Exception ex)
    {

    }
                
}


[Test]
public void UpdateProfileA()
{
    UpdateProfileRequest request = new UpdateProfileRequest();

    request.UserName = "trustev";
    request.Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook;
    request.Id = "1";
    SocialNetwork socialNetwork1 = new SocialNetwork { Id = "2", Type = Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Twitter, LongTermAccessToken = "long term token", Secret = "secret", ShortTermAccessToken = "short term token", LongTermAccessTokenExpiry = DateTime.UtcNow.AddDays(+30), ShortTermAccessTokenExpiry = DateTime.UtcNow.AddHours(+2) };

    IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();
    socialNetworks.Add(socialNetwork1);
    request.SocialNetworks = socialNetworks;

    UpdateProfileResponse response = _socialService.UpdateProfile(request);
    Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
}



        [Test]
    public void DeleteProfile()
    {

        DeleteProfileRequest request = new DeleteProfileRequest();

        request.UserName = "trustev";

        SocialNetwork socialNetwork4 = new SocialNetwork { Id = "1", Type =Trustev.Api.v1.Services.Social.ConstantsSocialNetworkType.Facebook };

        IList<SocialNetwork> socialNetworks = new List<SocialNetwork>();
        socialNetworks.Add(socialNetwork4);

        request.SocialNetworks = socialNetworks;

        DeleteProfileResponse response = _socialService.DeleteProfile(request);
        Console.WriteLine("\nMessage: {0} Code: {1}", response.Message, response.Code);
    }

}


}
}
