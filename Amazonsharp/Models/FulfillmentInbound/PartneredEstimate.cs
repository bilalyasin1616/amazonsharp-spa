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
    /// The estimated shipping cost for a shipment using an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public partial class PartneredEstimate : IEquatable<PartneredEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredEstimate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartneredEstimate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredEstimate" /> class.
        /// </summary>
        /// <param name="Amount">The amount that the Amazon-partnered carrier will charge to ship the inbound shipment. (required).</param>
        /// <param name="ConfirmDeadline">The date in ISO 8601 date time format by which this estimate must be confirmed. After this date the estimate is no longer valid and cannot be confirmed.  Returned only if the TransportStatus value of the inbound shipment is ESTIMATED..</param>
        /// <param name="VoidDeadline">The date in ISO 8601 date time format after which a confirmed transportation request can no longer be voided. This date is 24 hours after a Small Parcel shipment transportation request is confirmed or one hour after a Less Than Truckload/Full Truckload (LTL/FTL) shipment transportation request is confirmed. After the void deadline passes the seller&#39;s account will be charged for the shipping cost.  Returned only if the TransportStatus value of the inbound shipment is CONFIRMED..</param>
        public PartneredEstimate(Amount Amount = default(Amount), TimeStampStringType ConfirmDeadline = default(TimeStampStringType), TimeStampStringType VoidDeadline = default(TimeStampStringType))
        {
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for PartneredEstimate and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            this.ConfirmDeadline = ConfirmDeadline;
            this.VoidDeadline = VoidDeadline;
        }

        /// <summary>
        /// The amount that the Amazon-partnered carrier will charge to ship the inbound shipment.
        /// </summary>
        /// <value>The amount that the Amazon-partnered carrier will charge to ship the inbound shipment.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The date in ISO 8601 date time format by which this estimate must be confirmed. After this date the estimate is no longer valid and cannot be confirmed.  Returned only if the TransportStatus value of the inbound shipment is ESTIMATED.
        /// </summary>
        /// <value>The date in ISO 8601 date time format by which this estimate must be confirmed. After this date the estimate is no longer valid and cannot be confirmed.  Returned only if the TransportStatus value of the inbound shipment is ESTIMATED.</value>
        [DataMember(Name = "ConfirmDeadline", EmitDefaultValue = false)]
        public TimeStampStringType ConfirmDeadline { get; set; }

        /// <summary>
        /// The date in ISO 8601 date time format after which a confirmed transportation request can no longer be voided. This date is 24 hours after a Small Parcel shipment transportation request is confirmed or one hour after a Less Than Truckload/Full Truckload (LTL/FTL) shipment transportation request is confirmed. After the void deadline passes the seller&#39;s account will be charged for the shipping cost.  Returned only if the TransportStatus value of the inbound shipment is CONFIRMED.
        /// </summary>
        /// <value>The date in ISO 8601 date time format after which a confirmed transportation request can no longer be voided. This date is 24 hours after a Small Parcel shipment transportation request is confirmed or one hour after a Less Than Truckload/Full Truckload (LTL/FTL) shipment transportation request is confirmed. After the void deadline passes the seller&#39;s account will be charged for the shipping cost.  Returned only if the TransportStatus value of the inbound shipment is CONFIRMED.</value>
        [DataMember(Name = "VoidDeadline", EmitDefaultValue = false)]
        public TimeStampStringType VoidDeadline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredEstimate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ConfirmDeadline: ").Append(ConfirmDeadline).Append("\n");
            sb.Append("  VoidDeadline: ").Append(VoidDeadline).Append("\n");
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
            return this.Equals(input as PartneredEstimate);
        }

        /// <summary>
        /// Returns true if PartneredEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredEstimate input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.ConfirmDeadline == input.ConfirmDeadline ||
                    (this.ConfirmDeadline != null &&
                    this.ConfirmDeadline.Equals(input.ConfirmDeadline))
                ) &&
                (
                    this.VoidDeadline == input.VoidDeadline ||
                    (this.VoidDeadline != null &&
                    this.VoidDeadline.Equals(input.VoidDeadline))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ConfirmDeadline != null)
                    hashCode = hashCode * 59 + this.ConfirmDeadline.GetHashCode();
                if (this.VoidDeadline != null)
                    hashCode = hashCode * 59 + this.VoidDeadline.GetHashCode();
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
