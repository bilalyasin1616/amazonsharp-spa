/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace AmazonSharp.Models.Finances
{
    /// <summary>
    /// An adjustment to the seller&#39;s account.
    /// </summary>
    [DataContract]
    public partial class AdjustmentEvent : IEquatable<AdjustmentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustmentEvent" /> class.
        /// </summary>
        /// <param name="AdjustmentType">The type of adjustment.  Possible values:  * FBAInventoryReimbursement - An FBA inventory reimbursement to a seller&#39;s account. This occurs if a seller&#39;s inventory is damaged.  * ReserveEvent - A reserve event that is generated at the time of a settlement period closing. This occurs when some money from a seller&#39;s account is held back.  * PostageBilling - The amount paid by a seller for shipping labels.  * PostageRefund - The reimbursement of shipping labels purchased for orders that were canceled or refunded.  * LostOrDamagedReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account for a package that we lost or damaged.  * CanceledButPickedUpReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account. This occurs when a package is picked up and the order is subsequently canceled. This value is used only in the India marketplace.  * ReimbursementClawback - An Amazon Easy Ship reimbursement clawback from a seller&#39;s account. This occurs when a prior reimbursement is reversed. This value is used only in the India marketplace.  * SellerRewards - An award credited to a seller&#39;s account for their participation in an offer in the Seller Rewards program. Applies only to the India marketplace..</param>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="AdjustmentAmount">The amount adjusted as part of this event..</param>
        /// <param name="AdjustmentItemList">A list of information about adjustments to an account..</param>
        public AdjustmentEvent(string AdjustmentType = default(string), DateTime? PostedDate = default(DateTime?), Currency AdjustmentAmount = default(Currency), AdjustmentItemList AdjustmentItemList = default(AdjustmentItemList))
        {
            this.AdjustmentType = AdjustmentType;
            this.PostedDate = PostedDate;
            this.AdjustmentAmount = AdjustmentAmount;
            this.AdjustmentItemList = AdjustmentItemList;
        }

        /// <summary>
        /// The type of adjustment.  Possible values:  * FBAInventoryReimbursement - An FBA inventory reimbursement to a seller&#39;s account. This occurs if a seller&#39;s inventory is damaged.  * ReserveEvent - A reserve event that is generated at the time of a settlement period closing. This occurs when some money from a seller&#39;s account is held back.  * PostageBilling - The amount paid by a seller for shipping labels.  * PostageRefund - The reimbursement of shipping labels purchased for orders that were canceled or refunded.  * LostOrDamagedReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account for a package that we lost or damaged.  * CanceledButPickedUpReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account. This occurs when a package is picked up and the order is subsequently canceled. This value is used only in the India marketplace.  * ReimbursementClawback - An Amazon Easy Ship reimbursement clawback from a seller&#39;s account. This occurs when a prior reimbursement is reversed. This value is used only in the India marketplace.  * SellerRewards - An award credited to a seller&#39;s account for their participation in an offer in the Seller Rewards program. Applies only to the India marketplace.
        /// </summary>
        /// <value>The type of adjustment.  Possible values:  * FBAInventoryReimbursement - An FBA inventory reimbursement to a seller&#39;s account. This occurs if a seller&#39;s inventory is damaged.  * ReserveEvent - A reserve event that is generated at the time of a settlement period closing. This occurs when some money from a seller&#39;s account is held back.  * PostageBilling - The amount paid by a seller for shipping labels.  * PostageRefund - The reimbursement of shipping labels purchased for orders that were canceled or refunded.  * LostOrDamagedReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account for a package that we lost or damaged.  * CanceledButPickedUpReimbursement - An Amazon Easy Ship reimbursement to a seller&#39;s account. This occurs when a package is picked up and the order is subsequently canceled. This value is used only in the India marketplace.  * ReimbursementClawback - An Amazon Easy Ship reimbursement clawback from a seller&#39;s account. This occurs when a prior reimbursement is reversed. This value is used only in the India marketplace.  * SellerRewards - An award credited to a seller&#39;s account for their participation in an offer in the Seller Rewards program. Applies only to the India marketplace.</value>
        [DataMember(Name = "AdjustmentType", EmitDefaultValue = false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The amount adjusted as part of this event.
        /// </summary>
        /// <value>The amount adjusted as part of this event.</value>
        [DataMember(Name = "AdjustmentAmount", EmitDefaultValue = false)]
        public Currency AdjustmentAmount { get; set; }

        /// <summary>
        /// A list of information about adjustments to an account.
        /// </summary>
        /// <value>A list of information about adjustments to an account.</value>
        [DataMember(Name = "AdjustmentItemList", EmitDefaultValue = false)]
        public AdjustmentItemList AdjustmentItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdjustmentEvent {\n");
            sb.Append("  AdjustmentType: ").Append(AdjustmentType).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  AdjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
            sb.Append("  AdjustmentItemList: ").Append(AdjustmentItemList).Append("\n");
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
            return this.Equals(input as AdjustmentEvent);
        }

        /// <summary>
        /// Returns true if AdjustmentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustmentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustmentEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdjustmentType == input.AdjustmentType ||
                    (this.AdjustmentType != null &&
                    this.AdjustmentType.Equals(input.AdjustmentType))
                ) &&
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.AdjustmentAmount == input.AdjustmentAmount ||
                    (this.AdjustmentAmount != null &&
                    this.AdjustmentAmount.Equals(input.AdjustmentAmount))
                ) &&
                (
                    this.AdjustmentItemList == input.AdjustmentItemList ||
                    (this.AdjustmentItemList != null &&
                    this.AdjustmentItemList.Equals(input.AdjustmentItemList))
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
                if (this.AdjustmentType != null)
                    hashCode = hashCode * 59 + this.AdjustmentType.GetHashCode();
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.AdjustmentAmount != null)
                    hashCode = hashCode * 59 + this.AdjustmentAmount.GetHashCode();
                if (this.AdjustmentItemList != null)
                    hashCode = hashCode * 59 + this.AdjustmentItemList.GetHashCode();
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
