using AmazonSharp.Models;
using AmazonSharp.Models.CatalogItems;
using AmazonSharp.Models.Orders;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonSharp.Services
{
    public class ProductService : RequestService
    {
        public ProductService(AwsCredentials awsCredentials, ClientToken clientToken, MarketPlaceId marketPlaceId) : base(awsCredentials, clientToken, marketPlaceId)
        {

        }

        public ItemList GetAll(List<KeyValuePair<string, string>> queryParameters = null)
        {
            CreateAuthorizedRequest(CategoryApiUrls.Items, RestSharp.Method.GET, queryParameters);
            var response = ExecuteRequest<ListCatalogItemsResponse>();
            return response.Payload.Items;
        }
    }
}
