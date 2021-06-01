namespace AmazonSharp.Services
{

    public static class EnvironemntManager
    {
        public static Environments Environemnt { get; set; } = Environments.Production;
        public enum Environments
        {
            Sandbox, Production
        }
    }

    public class ApiUrls
    {
        protected static string AmazonSandboxUrl { get; } = "https://sandbox.sellingpartnerapi-na.amazon.com";
        protected static string AmazonProductionUrl { get; } = "";
        protected static string UsMarketPlaceId { get; } = "EBAY_US";
        protected static string ContentLanguage { get; } = "en-US";

        protected static string ApiBaseUrl
        {
            get
            {
                return EnvironemntManager.Environemnt == EnvironemntManager.Environments.Sandbox ? AmazonSandboxUrl : AmazonProductionUrl;
            }
        }

        protected class OAuthUrls
        {
            public static string TokenUrl
            {
                get => $"{ApiBaseUrl}/identity/v1/oauth2/token";
            }
            public static string RefreshTokenUrl
            {
                get => $"{ApiBaseUrl}/identity/v1/oauth2/token";
            }
        }

        protected class TaxonomyApiUrls
        {
            private readonly static string _resourceBaseUrl = "/commerce/taxonomy/v1_beta";
            public static string getDefaultCategoryTreeIdUrl
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/get_default_category_tree_id";
            }
            public static string CategoryTreeUrl
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/category_tree";
            }
            public static string GetItemAspectsForCategory
            {
                get => $"/get_item_aspects_for_category";
            }
        }

        protected class InventoryApiUrls
        {
            private readonly static string _resourceBaseUrl = "/sell/inventory/v1";
            public static string bulkCreateOrReplaceInventoryItemUrl
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/bulk_create_or_replace_inventory_item";
            }
            public static string InventoryItemUrl
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/inventory_item";
            }
            public static string InventoryItemGroupUrl
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/inventory_item_group";
            }
            public static string Offer
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/offer";
            }
            public static string BulkCreateOffer
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/bulk_create_offer";
            }
            public static string BulkPublishOffer
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/bulk_publish_offer";
            }
            public static string PublishByInventoryItemGroup
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/publish_by_inventory_item_group";
            }
            public static string WithdrawByInventoryItemGroup
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/withdraw_by_inventory_item_group";
            }
            public static string Location
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/location";
            }
        }

        protected class AccountApiUrls
        {
            private readonly static string _resourceBaseUrl = "/sell/account/v1";
            public static string returnPolicy
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/return_policy";
            }
            public static string FulfillmentPolicy
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/fulfillment_policy";
            }
            public static string PayementPolicy
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/payment_policy";
            }
            public static string Privilege
            {
                get => $"{ApiBaseUrl}{_resourceBaseUrl}/privilege";
            }
        }

        protected class OrdersApiUrls
        {
            private readonly static string _resourceBaseUrl = "/orders/v0";
            public static string Orders
            {
                get => $"{_resourceBaseUrl}/orders";
            }
            public static string OrderItems(string orderId) => $"{_resourceBaseUrl}/orders/{orderId}/orderItems";
            public static string OrderBuyerInfo(string orderId) => $"{_resourceBaseUrl}/orders/{orderId}/buyerInfo";
            public static string OrderShipmentInfo(string orderId) => $"{_resourceBaseUrl}/orders/{orderId}/address";
        }

        protected class CategoryApiUrls
        {
            private readonly static string _resourceBaseUrl = "/catalog/v0";
            public static string Items
            {
                get => $"{_resourceBaseUrl}/items";
            }
        }
    }




}
