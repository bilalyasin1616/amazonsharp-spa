using AmazonSharp.Models;
using AmazonSharp.Models.Orders;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonSharp.Services
{
    public class OrderService : RequestService
    {
        public OrderService(AwsCredentials awsCredentials, ClientToken clientToken, MarketPlaceId marketPlaceId) : base(awsCredentials, clientToken, marketPlaceId)
        {

        }

        public List<Order> GetAll(List<KeyValuePair<string, string>> queryParameters = null)
        {
            MarketPlaceParam = MarketPlaceParamEnum.MarketplaceIds;
            CreateAuthorizedRequest(OrdersApiUrls.Orders, RestSharp.Method.GET, queryParameters);
            var response = ExecuteRequest<GetOrdersResponse>();
            return response.Payload.Orders;
        }

        public OrderItemList GetAllOrderItems(string orderId,List<KeyValuePair<string, string>> queryParameters = null)
        {
            MarketPlaceParam = MarketPlaceParamEnum.MarketplaceIds;
            CreateAuthorizedRequest(OrdersApiUrls.OrderItems(orderId), RestSharp.Method.GET, queryParameters);
            var response = ExecuteRequest<GetOrderItemsResponse>();
            return response.Payload.OrderItems;
        }

        public OrderBuyerInfo GetOrderBuyerInfo(string orderId, List<KeyValuePair<string, string>> queryParameters = null)
        {
            MarketPlaceParam = MarketPlaceParamEnum.MarketplaceIds;
            CreateAuthorizedRequest(OrdersApiUrls.OrderBuyerInfo(orderId), RestSharp.Method.GET, queryParameters);
            var response = ExecuteRequest<GetOrderBuyerInfoResponse>();
            return response.Payload;
        }

        public Address GetOrderShipmentInfo(string orderId, List<KeyValuePair<string, string>> queryParameters = null)
        {
            MarketPlaceParam = MarketPlaceParamEnum.MarketplaceIds;
            CreateAuthorizedRequest(OrdersApiUrls.OrderShipmentInfo(orderId), RestSharp.Method.GET, queryParameters);
            var response = ExecuteRequest<GetOrderAddressResponse>();
            return response.Payload.ShippingAddress;
        }
    }
}
