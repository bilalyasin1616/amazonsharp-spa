/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AmazonSharp.Models.FulfillmentInbound
{
    /// <summary>
    /// The preference for label preparation for an inbound shipment.
    /// </summary>
    /// <value>The preference for label preparation for an inbound shipment.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum LabelPrepPreference
    {

        /// <summary>
        /// Enum SELLERLABEL for value: SELLER_LABEL
        /// </summary>
        [EnumMember(Value = "SELLER_LABEL")]
        SELLERLABEL = 1,

        /// <summary>
        /// Enum AMAZONLABELONLY for value: AMAZON_LABEL_ONLY
        /// </summary>
        [EnumMember(Value = "AMAZON_LABEL_ONLY")]
        AMAZONLABELONLY = 2,

        /// <summary>
        /// Enum AMAZONLABELPREFERRED for value: AMAZON_LABEL_PREFERRED
        /// </summary>
        [EnumMember(Value = "AMAZON_LABEL_PREFERRED")]
        AMAZONLABELPREFERRED = 3
    }

}
