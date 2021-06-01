/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.FulfillmentOutbound
{
    /// <summary>
    /// ListAllFulfillmentOrdersResult
    /// </summary>
    [DataContract]
    public partial class ListAllFulfillmentOrdersResult : IEquatable<ListAllFulfillmentOrdersResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllFulfillmentOrdersResult" /> class.
        /// </summary>
        /// <param name="NextToken">When present and not empty, pass this string token in the next request to return the next response page..</param>
        /// <param name="FulfillmentOrders">A list of fulfillment order information..</param>
        public ListAllFulfillmentOrdersResult(string NextToken = default(string), FulfillmentOrderList FulfillmentOrders = default(FulfillmentOrderList))
        {
            this.NextToken = NextToken;
            this.FulfillmentOrders = FulfillmentOrders;
        }

        /// <summary>
        /// When present and not empty, pass this string token in the next request to return the next response page.
        /// </summary>
        /// <value>When present and not empty, pass this string token in the next request to return the next response page.</value>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// A list of fulfillment order information.
        /// </summary>
        /// <value>A list of fulfillment order information.</value>
        [DataMember(Name = "FulfillmentOrders", EmitDefaultValue = false)]
        public FulfillmentOrderList FulfillmentOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllFulfillmentOrdersResult {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  FulfillmentOrders: ").Append(FulfillmentOrders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllFulfillmentOrdersResult);
        }

        /// <summary>
        /// Returns true if ListAllFulfillmentOrdersResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllFulfillmentOrdersResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllFulfillmentOrdersResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) &&
                (
                    this.FulfillmentOrders == input.FulfillmentOrders ||
                    (this.FulfillmentOrders != null &&
                    this.FulfillmentOrders.Equals(input.FulfillmentOrders))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
                if (this.FulfillmentOrders != null)
                    hashCode = hashCode * 59 + this.FulfillmentOrders.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
