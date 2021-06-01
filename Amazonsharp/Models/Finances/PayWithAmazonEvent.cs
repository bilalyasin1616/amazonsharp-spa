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
    /// An event related to the seller&#39;s Pay with Amazon account.
    /// </summary>
    [DataContract]
    public partial class PayWithAmazonEvent : IEquatable<PayWithAmazonEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayWithAmazonEvent" /> class.
        /// </summary>
        /// <param name="SellerOrderId">An order identifier that is specified by the seller..</param>
        /// <param name="TransactionPostedDate">The date and time when the payment transaction is posted. In ISO 8601 date time format..</param>
        /// <param name="BusinessObjectType">The type of business object..</param>
        /// <param name="SalesChannel">The sales channel for the transaction..</param>
        /// <param name="Charge">The charge associated with the event..</param>
        /// <param name="FeeList">A list of fees associated with the event..</param>
        /// <param name="PaymentAmountType">The type of payment.  Possible values:  * Sales.</param>
        /// <param name="AmountDescription">A short description of this payment event..</param>
        /// <param name="FulfillmentChannel">The fulfillment channel.  Possible values:  * AFN - Amazon Fulfillment Network (Fulfillment by Amazon)  * MFN - Merchant Fulfillment Network (self-fulfilled).</param>
        /// <param name="StoreName">The store name where the event occurred..</param>
        public PayWithAmazonEvent(string SellerOrderId = default(string), DateTime? TransactionPostedDate = default(DateTime?), string BusinessObjectType = default(string), string SalesChannel = default(string), ChargeComponent Charge = default(ChargeComponent), FeeComponentList FeeList = default(FeeComponentList), string PaymentAmountType = default(string), string AmountDescription = default(string), string FulfillmentChannel = default(string), string StoreName = default(string))
        {
            this.SellerOrderId = SellerOrderId;
            this.TransactionPostedDate = TransactionPostedDate;
            this.BusinessObjectType = BusinessObjectType;
            this.SalesChannel = SalesChannel;
            this.Charge = Charge;
            this.FeeList = FeeList;
            this.PaymentAmountType = PaymentAmountType;
            this.AmountDescription = AmountDescription;
            this.FulfillmentChannel = FulfillmentChannel;
            this.StoreName = StoreName;
        }

        /// <summary>
        /// An order identifier that is specified by the seller.
        /// </summary>
        /// <value>An order identifier that is specified by the seller.</value>
        [DataMember(Name = "SellerOrderId", EmitDefaultValue = false)]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// The date and time when the payment transaction is posted. In ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time when the payment transaction is posted. In ISO 8601 date time format.</value>
        [DataMember(Name = "TransactionPostedDate", EmitDefaultValue = false)]
        public DateTime? TransactionPostedDate { get; set; }

        /// <summary>
        /// The type of business object.
        /// </summary>
        /// <value>The type of business object.</value>
        [DataMember(Name = "BusinessObjectType", EmitDefaultValue = false)]
        public string BusinessObjectType { get; set; }

        /// <summary>
        /// The sales channel for the transaction.
        /// </summary>
        /// <value>The sales channel for the transaction.</value>
        [DataMember(Name = "SalesChannel", EmitDefaultValue = false)]
        public string SalesChannel { get; set; }

        /// <summary>
        /// The charge associated with the event.
        /// </summary>
        /// <value>The charge associated with the event.</value>
        [DataMember(Name = "Charge", EmitDefaultValue = false)]
        public ChargeComponent Charge { get; set; }

        /// <summary>
        /// A list of fees associated with the event.
        /// </summary>
        /// <value>A list of fees associated with the event.</value>
        [DataMember(Name = "FeeList", EmitDefaultValue = false)]
        public FeeComponentList FeeList { get; set; }

        /// <summary>
        /// The type of payment.  Possible values:  * Sales
        /// </summary>
        /// <value>The type of payment.  Possible values:  * Sales</value>
        [DataMember(Name = "PaymentAmountType", EmitDefaultValue = false)]
        public string PaymentAmountType { get; set; }

        /// <summary>
        /// A short description of this payment event.
        /// </summary>
        /// <value>A short description of this payment event.</value>
        [DataMember(Name = "AmountDescription", EmitDefaultValue = false)]
        public string AmountDescription { get; set; }

        /// <summary>
        /// The fulfillment channel.  Possible values:  * AFN - Amazon Fulfillment Network (Fulfillment by Amazon)  * MFN - Merchant Fulfillment Network (self-fulfilled)
        /// </summary>
        /// <value>The fulfillment channel.  Possible values:  * AFN - Amazon Fulfillment Network (Fulfillment by Amazon)  * MFN - Merchant Fulfillment Network (self-fulfilled)</value>
        [DataMember(Name = "FulfillmentChannel", EmitDefaultValue = false)]
        public string FulfillmentChannel { get; set; }

        /// <summary>
        /// The store name where the event occurred.
        /// </summary>
        /// <value>The store name where the event occurred.</value>
        [DataMember(Name = "StoreName", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayWithAmazonEvent {\n");
            sb.Append("  SellerOrderId: ").Append(SellerOrderId).Append("\n");
            sb.Append("  TransactionPostedDate: ").Append(TransactionPostedDate).Append("\n");
            sb.Append("  BusinessObjectType: ").Append(BusinessObjectType).Append("\n");
            sb.Append("  SalesChannel: ").Append(SalesChannel).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  FeeList: ").Append(FeeList).Append("\n");
            sb.Append("  PaymentAmountType: ").Append(PaymentAmountType).Append("\n");
            sb.Append("  AmountDescription: ").Append(AmountDescription).Append("\n");
            sb.Append("  FulfillmentChannel: ").Append(FulfillmentChannel).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
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
            return this.Equals(input as PayWithAmazonEvent);
        }

        /// <summary>
        /// Returns true if PayWithAmazonEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PayWithAmazonEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayWithAmazonEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SellerOrderId == input.SellerOrderId ||
                    (this.SellerOrderId != null &&
                    this.SellerOrderId.Equals(input.SellerOrderId))
                ) &&
                (
                    this.TransactionPostedDate == input.TransactionPostedDate ||
                    (this.TransactionPostedDate != null &&
                    this.TransactionPostedDate.Equals(input.TransactionPostedDate))
                ) &&
                (
                    this.BusinessObjectType == input.BusinessObjectType ||
                    (this.BusinessObjectType != null &&
                    this.BusinessObjectType.Equals(input.BusinessObjectType))
                ) &&
                (
                    this.SalesChannel == input.SalesChannel ||
                    (this.SalesChannel != null &&
                    this.SalesChannel.Equals(input.SalesChannel))
                ) &&
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                ) &&
                (
                    this.FeeList == input.FeeList ||
                    (this.FeeList != null &&
                    this.FeeList.Equals(input.FeeList))
                ) &&
                (
                    this.PaymentAmountType == input.PaymentAmountType ||
                    (this.PaymentAmountType != null &&
                    this.PaymentAmountType.Equals(input.PaymentAmountType))
                ) &&
                (
                    this.AmountDescription == input.AmountDescription ||
                    (this.AmountDescription != null &&
                    this.AmountDescription.Equals(input.AmountDescription))
                ) &&
                (
                    this.FulfillmentChannel == input.FulfillmentChannel ||
                    (this.FulfillmentChannel != null &&
                    this.FulfillmentChannel.Equals(input.FulfillmentChannel))
                ) &&
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
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
                if (this.SellerOrderId != null)
                    hashCode = hashCode * 59 + this.SellerOrderId.GetHashCode();
                if (this.TransactionPostedDate != null)
                    hashCode = hashCode * 59 + this.TransactionPostedDate.GetHashCode();
                if (this.BusinessObjectType != null)
                    hashCode = hashCode * 59 + this.BusinessObjectType.GetHashCode();
                if (this.SalesChannel != null)
                    hashCode = hashCode * 59 + this.SalesChannel.GetHashCode();
                if (this.Charge != null)
                    hashCode = hashCode * 59 + this.Charge.GetHashCode();
                if (this.FeeList != null)
                    hashCode = hashCode * 59 + this.FeeList.GetHashCode();
                if (this.PaymentAmountType != null)
                    hashCode = hashCode * 59 + this.PaymentAmountType.GetHashCode();
                if (this.AmountDescription != null)
                    hashCode = hashCode * 59 + this.AmountDescription.GetHashCode();
                if (this.FulfillmentChannel != null)
                    hashCode = hashCode * 59 + this.FulfillmentChannel.GetHashCode();
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
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
