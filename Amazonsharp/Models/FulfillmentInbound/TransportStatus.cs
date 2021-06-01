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
    /// Indicates the status of the Amazon-partnered carrier shipment.
    /// </summary>
    /// <value>Indicates the status of the Amazon-partnered carrier shipment.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum TransportStatus
    {

        /// <summary>
        /// Enum WORKING for value: WORKING
        /// </summary>
        [EnumMember(Value = "WORKING")]
        WORKING = 1,

        /// <summary>
        /// Enum ESTIMATING for value: ESTIMATING
        /// </summary>
        [EnumMember(Value = "ESTIMATING")]
        ESTIMATING = 2,

        /// <summary>
        /// Enum ESTIMATED for value: ESTIMATED
        /// </summary>
        [EnumMember(Value = "ESTIMATED")]
        ESTIMATED = 3,

        /// <summary>
        /// Enum ERRORONESTIMATING for value: ERROR_ON_ESTIMATING
        /// </summary>
        [EnumMember(Value = "ERROR_ON_ESTIMATING")]
        ERRORONESTIMATING = 4,

        /// <summary>
        /// Enum CONFIRMING for value: CONFIRMING
        /// </summary>
        [EnumMember(Value = "CONFIRMING")]
        CONFIRMING = 5,

        /// <summary>
        /// Enum CONFIRMED for value: CONFIRMED
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED = 6,

        /// <summary>
        /// Enum ERRORONCONFIRMING for value: ERROR_ON_CONFIRMING
        /// </summary>
        [EnumMember(Value = "ERROR_ON_CONFIRMING")]
        ERRORONCONFIRMING = 7,

        /// <summary>
        /// Enum VOIDING for value: VOIDING
        /// </summary>
        [EnumMember(Value = "VOIDING")]
        VOIDING = 8,

        /// <summary>
        /// Enum VOIDED for value: VOIDED
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED = 9,

        /// <summary>
        /// Enum ERRORINVOIDING for value: ERROR_IN_VOIDING
        /// </summary>
        [EnumMember(Value = "ERROR_IN_VOIDING")]
        ERRORINVOIDING = 10,

        /// <summary>
        /// Enum ERROR for value: ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 11
    }

}
