using Amazon;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AmazonSharp.Models;
using AmazonSharp.Runtime;
using RestSharp;
using System;
using System.Threading;

namespace AmazonSharp.Services
{
    public static class TokenService
    {
        public static bool IsTokenExpired(int? expiresIn, DateTime? lastUpdated, DateTime? dateCreated)
        {
            if (expiresIn == null)
                throw new Exception("Channel token expires in not defined");
            if (lastUpdated == null)
                if (dateCreated == null)
                    throw new Exception("Expires in or Last update date is null");
                else
                    return DateTime.UtcNow.Subtract((DateTime)dateCreated).TotalSeconds > expiresIn;
            else
                return DateTime.UtcNow.Subtract((DateTime)lastUpdated).TotalSeconds > expiresIn;
        }

        public static ClientToken RefreshAccessToken(ClientToken credentials)
        {
            var Client = new LWAClient(credentials.LWACredentials);
            credentials.AccessToken = Client.GetAccessToken();
            return credentials;
        }

        public static IRestRequest SignWithAccessToken(IRestRequest restRequest, string clientId, string clientSecret, string refreshToken)
        {
            var lwaAuthorizationCredentials = new LWAAuthorizationCredentials
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                Endpoint = new Uri("https://api.amazon.com/auth/o2/token"),
                RefreshToken = refreshToken,
            };

            return new LWAAuthorizationSigner(lwaAuthorizationCredentials).Sign(restRequest);
        }

        public static IRestRequest SignWithSTSKeysAndSecurityToken(IRestRequest restRequest, string host, string roleARN, string accessKey, string secretKey)
        {
            AssumeRoleResponse response1 = null;
            using (var STSClient = new AmazonSecurityTokenServiceClient(accessKey, secretKey, RegionEndpoint.USEast1))
            {
                var req = new AssumeRoleRequest()
                {
                    RoleArn = roleARN,
                    DurationSeconds = 950, //put anything you want here
                    RoleSessionName = Guid.NewGuid().ToString()
                };

                response1 = STSClient.AssumeRoleAsync(req, new CancellationToken()).Result;
            }

            //auth step 3
            var awsAuthenticationCredentials = new AWSAuthenticationCredentials
            {
                AccessKeyId = response1.Credentials.AccessKeyId,
                SecretKey = response1.Credentials.SecretAccessKey,
                Region = "us-east-1"
            };

            restRequest.AddHeader("x-amz-security-token", response1.Credentials.SessionToken);

            return new AWSSigV4Signer(awsAuthenticationCredentials)
                            .Sign(restRequest, host);
        }
    }
}
