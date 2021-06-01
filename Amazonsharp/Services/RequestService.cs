using AmazonSharp.Models;
using AmazonSharp.Models.CatalogItems;
using AmazonSharp.Models.Exceptions;
using AmazonSharp.Models.Filters;
using AmazonSharp.Models.Orders;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace AmazonSharp.Services
{
    public class RequestService : ApiUrls
    {
        protected RestClient RequestClient { get; set; }
        protected IRestRequest Request { get; set; }
        protected AwsCredentials AwsCredentials { get; set; }
        public ClientToken ClientToken { get; set; }
        protected MarketPlaceParamEnum MarketPlaceParam { get; set; } = MarketPlaceParamEnum.MarketplaceId;
        protected MarketPlaceId MarketPlaceId { get; set; }

        /// <summary>
        /// Creates request base service
        /// </summary>
        /// <param name="awsCredentials">Contains api clients information</param>
        /// <param name="clientToken">Contains current user's account api keys</param>
        public RequestService(AwsCredentials awsCredentials, ClientToken clientToken, MarketPlaceId marketPlaceId)
        {
            AwsCredentials = awsCredentials;
            ClientToken = clientToken;
            MarketPlaceId = marketPlaceId;
        }

        /// <summary>
        /// Checks if token is refreshed after creating the sevice instance
        /// </summary>
        /// <param name="lastUpdated">last time the tokken was updated</param>
        /// <returns></returns>
        public bool IsAccessTokenRefreshed(DateTime lastUpdated)
        {
            return lastUpdated != ClientToken.LastUpdated;
        }

        private void CreateRequest(string url, Method method)
        {
            RequestClient = new RestClient(ApiBaseUrl);
            Request = new RestRequest(url, method);
        }

        protected void CreateAuthorizedRequest(string url, Method method, List<KeyValuePair<string, string>> queryParameters = null)
        {
            RefreshToken();
            CreateRequest(url, method);
            AddMarketPlaceId();
            AddQueryParameters(queryParameters);
            AddAccessToken();
        }

        protected void CreateAuthorizedPagedRequest(AmazonFilter filter, string url, Method method)
        {
            RefreshToken();
            if (filter.NextPage != null)
                CreateRequest(filter.NextPage, method);
            else
            {
                CreateRequest(url, method);
                AddLimitHeader(filter.Limit);
            }
            AddAccessToken();
        }

        /// <summary>
        /// Executes the request
        /// </summary>
        /// <typeparam name="T">Type to parse response to</typeparam>
        /// <returns>Returns data of T type</returns>
        protected T ExecuteRequest<T>() where T : new()
        {
            Request = TokenService.SignWithSTSKeysAndSecurityToken(Request, RequestClient.BaseUrl.Host, AwsCredentials.RoleARN, AwsCredentials.AWSKey, AwsCredentials.AWSSecret);
            var response = RequestClient.Execute<T>(Request);
            ParseResponse(response);
            return response.Data;
        }

        /// <summary>
        /// Executes the request 
        /// </summary>
        /// <typeparam name="T">Type to parse response to</typeparam>
        /// <returns>Returns raw response</returns>
        protected IRestResponse ExecuteRequest()
        {
            var response = RequestClient.Execute(Request);
            ParseResponse(response);
            return response;
        }

        protected void ParseResponse(IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
                return;
            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new NotFoundException("Resource that you are looking for is not found", response);
            else
                throw new AmazonException("Amazon Api didn't respond with Okay, see exception for more details", response);
        }

        protected void AddMarketPlaceId()
        {
            Request.AddQueryParameter(MarketPlaceParam.ToString(), MarketPlaceId.Value);
        }

        protected void AddQueryParameters(List<KeyValuePair<string, string>> queryParameters)
        {
            if (queryParameters != null)
                queryParameters.ForEach(qp => Request.AddQueryParameter(qp.Key, qp.Value));
        }

        protected void AddLimitHeader(int limit)
        {
            Request.AddQueryParameter("limit", limit.ToString());
        }

        protected void AddAccessToken()
        {
            Request.AddHeader("x-amz-access-token", ClientToken.AccessToken);
        }

        protected void RefreshToken()
        {
            ClientToken = TokenService.RefreshAccessToken(ClientToken);
        }

    }

}
