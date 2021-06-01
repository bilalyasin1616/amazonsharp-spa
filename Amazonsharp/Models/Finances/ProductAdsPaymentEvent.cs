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
    /// A Sponsored Products payment event.
    /// </summary>
    [DataContract]
    public partial class ProductAdsPaymentEvent : IEquatable<ProductAdsPaymentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAdsPaymentEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="TransactionType">Indicates if the transaction is for a charge or a refund.  Possible values:  * charge - Charge  * refund - Refund.</param>
        /// <param name="InvoiceId">Identifier for the invoice that the transaction appears in..</param>
        /// <param name="BaseValue">Base amount of the transaction, before tax..</param>
        /// <param name="TaxValue">Tax amount of the transaction..</param>
        /// <param name="TransactionValue">The total amount of the transaction. Equal to baseValue + taxValue..</param>
        public ProductAdsPaymentEvent(DateTime? PostedDate = default(DateTime?), string TransactionType = default(string), string InvoiceId = default(string), Currency BaseValue = default(Currency), Currency TaxValue = default(Currency), Currency TransactionValue = default(Currency))
        {
            this.PostedDate = PostedDate;
            this.TransactionType = TransactionType;
            this.InvoiceId = InvoiceId;
            this.BaseValue = BaseValue;
            this.TaxValue = TaxValue;
            this.TransactionValue = TransactionValue;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "postedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// Indicates if the transaction is for a charge or a refund.  Possible values:  * charge - Charge  * refund - Refund
        /// </summary>
        /// <value>Indicates if the transaction is for a charge or a refund.  Possible values:  * charge - Charge  * refund - Refund</value>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Identifier for the invoice that the transaction appears in.
        /// </summary>
        /// <value>Identifier for the invoice that the transaction appears in.</value>
        [DataMember(Name = "invoiceId", EmitDefaultValue = false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Base amount of the transaction, before tax.
        /// </summary>
        /// <value>Base amount of the transaction, before tax.</value>
        [DataMember(Name = "baseValue", EmitDefaultValue = false)]
        public Currency BaseValue { get; set; }

        /// <summary>
        /// Tax amount of the transaction.
        /// </summary>
        /// <value>Tax amount of the transaction.</value>
        [DataMember(Name = "taxValue", EmitDefaultValue = false)]
        public Currency TaxValue { get; set; }

        /// <summary>
        /// The total amount of the transaction. Equal to baseValue + taxValue.
        /// </summary>
        /// <value>The total amount of the transaction. Equal to baseValue + taxValue.</value>
        [DataMember(Name = "transactionValue", EmitDefaultValue = false)]
        public Currency TransactionValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductAdsPaymentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  BaseValue: ").Append(BaseValue).Append("\n");
            sb.Append("  TaxValue: ").Append(TaxValue).Append("\n");
            sb.Append("  TransactionValue: ").Append(TransactionValue).Append("\n");
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
            return this.Equals(input as ProductAdsPaymentEvent);
        }

        /// <summary>
        /// Returns true if ProductAdsPaymentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductAdsPaymentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductAdsPaymentEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) &&
                (
                    this.BaseValue == input.BaseValue ||
                    (this.BaseValue != null &&
                    this.BaseValue.Equals(input.BaseValue))
                ) &&
                (
                    this.TaxValue == input.TaxValue ||
                    (this.TaxValue != null &&
                    this.TaxValue.Equals(input.TaxValue))
                ) &&
                (
                    this.TransactionValue == input.TransactionValue ||
                    (this.TransactionValue != null &&
                    this.TransactionValue.Equals(input.TransactionValue))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.BaseValue != null)
                    hashCode = hashCode * 59 + this.BaseValue.GetHashCode();
                if (this.TaxValue != null)
                    hashCode = hashCode * 59 + this.TaxValue.GetHashCode();
                if (this.TransactionValue != null)
                    hashCode = hashCode * 59 + this.TransactionValue.GetHashCode();
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
