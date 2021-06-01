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
    /// A loan advance, loan payment, or loan refund.
    /// </summary>
    [DataContract]
    public partial class LoanServicingEvent : IEquatable<LoanServicingEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanServicingEvent" /> class.
        /// </summary>
        /// <param name="LoanAmount">The amount of the loan..</param>
        /// <param name="SourceBusinessEventType">The type of event.  Possible values:  * LoanAdvance  * LoanPayment  * LoanRefund.</param>
        public LoanServicingEvent(Currency LoanAmount = default(Currency), string SourceBusinessEventType = default(string))
        {
            this.LoanAmount = LoanAmount;
            this.SourceBusinessEventType = SourceBusinessEventType;
        }

        /// <summary>
        /// The amount of the loan.
        /// </summary>
        /// <value>The amount of the loan.</value>
        [DataMember(Name = "LoanAmount", EmitDefaultValue = false)]
        public Currency LoanAmount { get; set; }

        /// <summary>
        /// The type of event.  Possible values:  * LoanAdvance  * LoanPayment  * LoanRefund
        /// </summary>
        /// <value>The type of event.  Possible values:  * LoanAdvance  * LoanPayment  * LoanRefund</value>
        [DataMember(Name = "SourceBusinessEventType", EmitDefaultValue = false)]
        public string SourceBusinessEventType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanServicingEvent {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  SourceBusinessEventType: ").Append(SourceBusinessEventType).Append("\n");
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
            return this.Equals(input as LoanServicingEvent);
        }

        /// <summary>
        /// Returns true if LoanServicingEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanServicingEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanServicingEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) &&
                (
                    this.SourceBusinessEventType == input.SourceBusinessEventType ||
                    (this.SourceBusinessEventType != null &&
                    this.SourceBusinessEventType.Equals(input.SourceBusinessEventType))
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
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.SourceBusinessEventType != null)
                    hashCode = hashCode * 59 + this.SourceBusinessEventType.GetHashCode();
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
