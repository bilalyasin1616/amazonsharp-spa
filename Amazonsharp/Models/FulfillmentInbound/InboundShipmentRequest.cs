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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.FulfillmentInbound
{
    /// <summary>
    /// The request schema for an inbound shipment.
    /// </summary>
    [DataContract]
    public partial class InboundShipmentRequest : IEquatable<InboundShipmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundShipmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipmentRequest" /> class.
        /// </summary>
        /// <param name="InboundShipmentHeader">InboundShipmentHeader (required).</param>
        /// <param name="InboundShipmentItems">InboundShipmentItems (required).</param>
        /// <param name="MarketplaceId">A marketplace identifier. Specifies the marketplace where the product would be stored. (required).</param>
        public InboundShipmentRequest(InboundShipmentHeader InboundShipmentHeader = default(InboundShipmentHeader), InboundShipmentItemList InboundShipmentItems = default(InboundShipmentItemList), string MarketplaceId = default(string))
        {
            // to ensure "InboundShipmentHeader" is required (not null)
            if (InboundShipmentHeader == null)
            {
                throw new InvalidDataException("InboundShipmentHeader is a required property for InboundShipmentRequest and cannot be null");
            }
            else
            {
                this.InboundShipmentHeader = InboundShipmentHeader;
            }
            // to ensure "InboundShipmentItems" is required (not null)
            if (InboundShipmentItems == null)
            {
                throw new InvalidDataException("InboundShipmentItems is a required property for InboundShipmentRequest and cannot be null");
            }
            else
            {
                this.InboundShipmentItems = InboundShipmentItems;
            }
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
            {
                throw new InvalidDataException("MarketplaceId is a required property for InboundShipmentRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = MarketplaceId;
            }
        }

        /// <summary>
        /// Gets or Sets InboundShipmentHeader
        /// </summary>
        [DataMember(Name = "InboundShipmentHeader", EmitDefaultValue = false)]
        public InboundShipmentHeader InboundShipmentHeader { get; set; }

        /// <summary>
        /// Gets or Sets InboundShipmentItems
        /// </summary>
        [DataMember(Name = "InboundShipmentItems", EmitDefaultValue = false)]
        public InboundShipmentItemList InboundShipmentItems { get; set; }

        /// <summary>
        /// A marketplace identifier. Specifies the marketplace where the product would be stored.
        /// </summary>
        /// <value>A marketplace identifier. Specifies the marketplace where the product would be stored.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundShipmentRequest {\n");
            sb.Append("  InboundShipmentHeader: ").Append(InboundShipmentHeader).Append("\n");
            sb.Append("  InboundShipmentItems: ").Append(InboundShipmentItems).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
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
            return this.Equals(input as InboundShipmentRequest);
        }

        /// <summary>
        /// Returns true if InboundShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundShipmentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InboundShipmentHeader == input.InboundShipmentHeader ||
                    (this.InboundShipmentHeader != null &&
                    this.InboundShipmentHeader.Equals(input.InboundShipmentHeader))
                ) &&
                (
                    this.InboundShipmentItems == input.InboundShipmentItems ||
                    (this.InboundShipmentItems != null &&
                    this.InboundShipmentItems.Equals(input.InboundShipmentItems))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
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
                if (this.InboundShipmentHeader != null)
                    hashCode = hashCode * 59 + this.InboundShipmentHeader.GetHashCode();
                if (this.InboundShipmentItems != null)
                    hashCode = hashCode * 59 + this.InboundShipmentItems.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
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
