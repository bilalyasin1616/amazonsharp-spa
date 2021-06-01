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
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSharp.Models.FulfillmentInbound
{
    /// <summary>
    /// GetPreorderInfoResult
    /// </summary>
    [DataContract]
    public partial class GetPreorderInfoResult : IEquatable<GetPreorderInfoResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreorderInfoResult" /> class.
        /// </summary>
        /// <param name="ShipmentContainsPreorderableItems">Indicates whether the shipment contains items that have been enabled for pre-order. For more information about enabling items for pre-order, see the Seller Central Help..</param>
        /// <param name="ShipmentConfirmedForPreorder">Indicates whether this shipment has been confirmed for pre-order..</param>
        /// <param name="NeedByDate">Date that the shipment would need to arrive at an Amazon fulfillment center to avoid delivery promise breaks for pre-ordered items if this shipment is later confirmed for pre-order. In YYYY-MM-DD format. See also the confirmPreorder operation..</param>
        /// <param name="ConfirmedFulfillableDate">Date in YYYY-MM-DD format that determines which pre-order items in the shipment are eligible for pre-order. If this shipment is confirmed for pre-order with a subsequent call to the confirmPreorder operation, the pre-order Buy Box will appear for any pre-order items in the shipment with a release date on or after this date. Call the getShipmentItems operation to get the release dates for the pre-order items in this shipment..</param>
        public GetPreorderInfoResult(bool? ShipmentContainsPreorderableItems = default(bool?), bool? ShipmentConfirmedForPreorder = default(bool?), DateStringType NeedByDate = default(DateStringType), DateStringType ConfirmedFulfillableDate = default(DateStringType))
        {
            this.ShipmentContainsPreorderableItems = ShipmentContainsPreorderableItems;
            this.ShipmentConfirmedForPreorder = ShipmentConfirmedForPreorder;
            this.NeedByDate = NeedByDate;
            this.ConfirmedFulfillableDate = ConfirmedFulfillableDate;
        }

        /// <summary>
        /// Indicates whether the shipment contains items that have been enabled for pre-order. For more information about enabling items for pre-order, see the Seller Central Help.
        /// </summary>
        /// <value>Indicates whether the shipment contains items that have been enabled for pre-order. For more information about enabling items for pre-order, see the Seller Central Help.</value>
        [DataMember(Name = "ShipmentContainsPreorderableItems", EmitDefaultValue = false)]
        public bool? ShipmentContainsPreorderableItems { get; set; }

        /// <summary>
        /// Indicates whether this shipment has been confirmed for pre-order.
        /// </summary>
        /// <value>Indicates whether this shipment has been confirmed for pre-order.</value>
        [DataMember(Name = "ShipmentConfirmedForPreorder", EmitDefaultValue = false)]
        public bool? ShipmentConfirmedForPreorder { get; set; }

        /// <summary>
        /// Date that the shipment would need to arrive at an Amazon fulfillment center to avoid delivery promise breaks for pre-ordered items if this shipment is later confirmed for pre-order. In YYYY-MM-DD format. See also the confirmPreorder operation.
        /// </summary>
        /// <value>Date that the shipment would need to arrive at an Amazon fulfillment center to avoid delivery promise breaks for pre-ordered items if this shipment is later confirmed for pre-order. In YYYY-MM-DD format. See also the confirmPreorder operation.</value>
        [DataMember(Name = "NeedByDate", EmitDefaultValue = false)]
        public DateStringType NeedByDate { get; set; }

        /// <summary>
        /// Date in YYYY-MM-DD format that determines which pre-order items in the shipment are eligible for pre-order. If this shipment is confirmed for pre-order with a subsequent call to the confirmPreorder operation, the pre-order Buy Box will appear for any pre-order items in the shipment with a release date on or after this date. Call the getShipmentItems operation to get the release dates for the pre-order items in this shipment.
        /// </summary>
        /// <value>Date in YYYY-MM-DD format that determines which pre-order items in the shipment are eligible for pre-order. If this shipment is confirmed for pre-order with a subsequent call to the confirmPreorder operation, the pre-order Buy Box will appear for any pre-order items in the shipment with a release date on or after this date. Call the getShipmentItems operation to get the release dates for the pre-order items in this shipment.</value>
        [DataMember(Name = "ConfirmedFulfillableDate", EmitDefaultValue = false)]
        public DateStringType ConfirmedFulfillableDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPreorderInfoResult {\n");
            sb.Append("  ShipmentContainsPreorderableItems: ").Append(ShipmentContainsPreorderableItems).Append("\n");
            sb.Append("  ShipmentConfirmedForPreorder: ").Append(ShipmentConfirmedForPreorder).Append("\n");
            sb.Append("  NeedByDate: ").Append(NeedByDate).Append("\n");
            sb.Append("  ConfirmedFulfillableDate: ").Append(ConfirmedFulfillableDate).Append("\n");
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
            return this.Equals(input as GetPreorderInfoResult);
        }

        /// <summary>
        /// Returns true if GetPreorderInfoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPreorderInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPreorderInfoResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShipmentContainsPreorderableItems == input.ShipmentContainsPreorderableItems ||
                    (this.ShipmentContainsPreorderableItems != null &&
                    this.ShipmentContainsPreorderableItems.Equals(input.ShipmentContainsPreorderableItems))
                ) &&
                (
                    this.ShipmentConfirmedForPreorder == input.ShipmentConfirmedForPreorder ||
                    (this.ShipmentConfirmedForPreorder != null &&
                    this.ShipmentConfirmedForPreorder.Equals(input.ShipmentConfirmedForPreorder))
                ) &&
                (
                    this.NeedByDate == input.NeedByDate ||
                    (this.NeedByDate != null &&
                    this.NeedByDate.Equals(input.NeedByDate))
                ) &&
                (
                    this.ConfirmedFulfillableDate == input.ConfirmedFulfillableDate ||
                    (this.ConfirmedFulfillableDate != null &&
                    this.ConfirmedFulfillableDate.Equals(input.ConfirmedFulfillableDate))
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
                if (this.ShipmentContainsPreorderableItems != null)
                    hashCode = hashCode * 59 + this.ShipmentContainsPreorderableItems.GetHashCode();
                if (this.ShipmentConfirmedForPreorder != null)
                    hashCode = hashCode * 59 + this.ShipmentConfirmedForPreorder.GetHashCode();
                if (this.NeedByDate != null)
                    hashCode = hashCode * 59 + this.NeedByDate.GetHashCode();
                if (this.ConfirmedFulfillableDate != null)
                    hashCode = hashCode * 59 + this.ConfirmedFulfillableDate.GetHashCode();
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
