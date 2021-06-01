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
    /// Information related to a financial event group.
    /// </summary>
    [DataContract]
    public partial class FinancialEventGroup : IEquatable<FinancialEventGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialEventGroup" /> class.
        /// </summary>
        /// <param name="FinancialEventGroupId">A unique identifier for the financial event group..</param>
        /// <param name="ProcessingStatus">The processing status of the financial event group indicates whether the balance of the financial event group is settled.  Possible values:  * Open  * Closed.</param>
        /// <param name="FundTransferStatus">The status of the fund transfer..</param>
        /// <param name="OriginalTotal">The total amount in the currency of the marketplace in which the transactions occurred..</param>
        /// <param name="ConvertedTotal">The total amount in the currency of the marketplace in which the funds were disbursed..</param>
        /// <param name="FundTransferDate">The date and time when the disbursement or charge was initiated. Only present for closed settlements. In ISO 8601 date time format..</param>
        /// <param name="TraceId">The trace identifier used by sellers to look up transactions externally..</param>
        /// <param name="AccountTail">The account tail of the payment instrument..</param>
        /// <param name="BeginningBalance">The balance at the beginning of the settlement period..</param>
        /// <param name="FinancialEventGroupStart">The date and time at which the financial event group is opened. In ISO 8601 date time format..</param>
        /// <param name="FinancialEventGroupEnd">The date and time at which the financial event group is closed. In ISO 8601 date time format..</param>
        public FinancialEventGroup(string FinancialEventGroupId = default(string), string ProcessingStatus = default(string), string FundTransferStatus = default(string), Currency OriginalTotal = default(Currency), Currency ConvertedTotal = default(Currency), DateTime? FundTransferDate = default(DateTime?), string TraceId = default(string), string AccountTail = default(string), Currency BeginningBalance = default(Currency), DateTime? FinancialEventGroupStart = default(DateTime?), DateTime? FinancialEventGroupEnd = default(DateTime?))
        {
            this.FinancialEventGroupId = FinancialEventGroupId;
            this.ProcessingStatus = ProcessingStatus;
            this.FundTransferStatus = FundTransferStatus;
            this.OriginalTotal = OriginalTotal;
            this.ConvertedTotal = ConvertedTotal;
            this.FundTransferDate = FundTransferDate;
            this.TraceId = TraceId;
            this.AccountTail = AccountTail;
            this.BeginningBalance = BeginningBalance;
            this.FinancialEventGroupStart = FinancialEventGroupStart;
            this.FinancialEventGroupEnd = FinancialEventGroupEnd;
        }

        /// <summary>
        /// A unique identifier for the financial event group.
        /// </summary>
        /// <value>A unique identifier for the financial event group.</value>
        [DataMember(Name = "FinancialEventGroupId", EmitDefaultValue = false)]
        public string FinancialEventGroupId { get; set; }

        /// <summary>
        /// The processing status of the financial event group indicates whether the balance of the financial event group is settled.  Possible values:  * Open  * Closed
        /// </summary>
        /// <value>The processing status of the financial event group indicates whether the balance of the financial event group is settled.  Possible values:  * Open  * Closed</value>
        [DataMember(Name = "ProcessingStatus", EmitDefaultValue = false)]
        public string ProcessingStatus { get; set; }

        /// <summary>
        /// The status of the fund transfer.
        /// </summary>
        /// <value>The status of the fund transfer.</value>
        [DataMember(Name = "FundTransferStatus", EmitDefaultValue = false)]
        public string FundTransferStatus { get; set; }

        /// <summary>
        /// The total amount in the currency of the marketplace in which the transactions occurred.
        /// </summary>
        /// <value>The total amount in the currency of the marketplace in which the transactions occurred.</value>
        [DataMember(Name = "OriginalTotal", EmitDefaultValue = false)]
        public Currency OriginalTotal { get; set; }

        /// <summary>
        /// The total amount in the currency of the marketplace in which the funds were disbursed.
        /// </summary>
        /// <value>The total amount in the currency of the marketplace in which the funds were disbursed.</value>
        [DataMember(Name = "ConvertedTotal", EmitDefaultValue = false)]
        public Currency ConvertedTotal { get; set; }

        /// <summary>
        /// The date and time when the disbursement or charge was initiated. Only present for closed settlements. In ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time when the disbursement or charge was initiated. Only present for closed settlements. In ISO 8601 date time format.</value>
        [DataMember(Name = "FundTransferDate", EmitDefaultValue = false)]
        public DateTime? FundTransferDate { get; set; }

        /// <summary>
        /// The trace identifier used by sellers to look up transactions externally.
        /// </summary>
        /// <value>The trace identifier used by sellers to look up transactions externally.</value>
        [DataMember(Name = "TraceId", EmitDefaultValue = false)]
        public string TraceId { get; set; }

        /// <summary>
        /// The account tail of the payment instrument.
        /// </summary>
        /// <value>The account tail of the payment instrument.</value>
        [DataMember(Name = "AccountTail", EmitDefaultValue = false)]
        public string AccountTail { get; set; }

        /// <summary>
        /// The balance at the beginning of the settlement period.
        /// </summary>
        /// <value>The balance at the beginning of the settlement period.</value>
        [DataMember(Name = "BeginningBalance", EmitDefaultValue = false)]
        public Currency BeginningBalance { get; set; }

        /// <summary>
        /// The date and time at which the financial event group is opened. In ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time at which the financial event group is opened. In ISO 8601 date time format.</value>
        [DataMember(Name = "FinancialEventGroupStart", EmitDefaultValue = false)]
        public DateTime? FinancialEventGroupStart { get; set; }

        /// <summary>
        /// The date and time at which the financial event group is closed. In ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time at which the financial event group is closed. In ISO 8601 date time format.</value>
        [DataMember(Name = "FinancialEventGroupEnd", EmitDefaultValue = false)]
        public DateTime? FinancialEventGroupEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialEventGroup {\n");
            sb.Append("  FinancialEventGroupId: ").Append(FinancialEventGroupId).Append("\n");
            sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
            sb.Append("  FundTransferStatus: ").Append(FundTransferStatus).Append("\n");
            sb.Append("  OriginalTotal: ").Append(OriginalTotal).Append("\n");
            sb.Append("  ConvertedTotal: ").Append(ConvertedTotal).Append("\n");
            sb.Append("  FundTransferDate: ").Append(FundTransferDate).Append("\n");
            sb.Append("  TraceId: ").Append(TraceId).Append("\n");
            sb.Append("  AccountTail: ").Append(AccountTail).Append("\n");
            sb.Append("  BeginningBalance: ").Append(BeginningBalance).Append("\n");
            sb.Append("  FinancialEventGroupStart: ").Append(FinancialEventGroupStart).Append("\n");
            sb.Append("  FinancialEventGroupEnd: ").Append(FinancialEventGroupEnd).Append("\n");
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
            return this.Equals(input as FinancialEventGroup);
        }

        /// <summary>
        /// Returns true if FinancialEventGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of FinancialEventGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialEventGroup input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FinancialEventGroupId == input.FinancialEventGroupId ||
                    (this.FinancialEventGroupId != null &&
                    this.FinancialEventGroupId.Equals(input.FinancialEventGroupId))
                ) &&
                (
                    this.ProcessingStatus == input.ProcessingStatus ||
                    (this.ProcessingStatus != null &&
                    this.ProcessingStatus.Equals(input.ProcessingStatus))
                ) &&
                (
                    this.FundTransferStatus == input.FundTransferStatus ||
                    (this.FundTransferStatus != null &&
                    this.FundTransferStatus.Equals(input.FundTransferStatus))
                ) &&
                (
                    this.OriginalTotal == input.OriginalTotal ||
                    (this.OriginalTotal != null &&
                    this.OriginalTotal.Equals(input.OriginalTotal))
                ) &&
                (
                    this.ConvertedTotal == input.ConvertedTotal ||
                    (this.ConvertedTotal != null &&
                    this.ConvertedTotal.Equals(input.ConvertedTotal))
                ) &&
                (
                    this.FundTransferDate == input.FundTransferDate ||
                    (this.FundTransferDate != null &&
                    this.FundTransferDate.Equals(input.FundTransferDate))
                ) &&
                (
                    this.TraceId == input.TraceId ||
                    (this.TraceId != null &&
                    this.TraceId.Equals(input.TraceId))
                ) &&
                (
                    this.AccountTail == input.AccountTail ||
                    (this.AccountTail != null &&
                    this.AccountTail.Equals(input.AccountTail))
                ) &&
                (
                    this.BeginningBalance == input.BeginningBalance ||
                    (this.BeginningBalance != null &&
                    this.BeginningBalance.Equals(input.BeginningBalance))
                ) &&
                (
                    this.FinancialEventGroupStart == input.FinancialEventGroupStart ||
                    (this.FinancialEventGroupStart != null &&
                    this.FinancialEventGroupStart.Equals(input.FinancialEventGroupStart))
                ) &&
                (
                    this.FinancialEventGroupEnd == input.FinancialEventGroupEnd ||
                    (this.FinancialEventGroupEnd != null &&
                    this.FinancialEventGroupEnd.Equals(input.FinancialEventGroupEnd))
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
                if (this.FinancialEventGroupId != null)
                    hashCode = hashCode * 59 + this.FinancialEventGroupId.GetHashCode();
                if (this.ProcessingStatus != null)
                    hashCode = hashCode * 59 + this.ProcessingStatus.GetHashCode();
                if (this.FundTransferStatus != null)
                    hashCode = hashCode * 59 + this.FundTransferStatus.GetHashCode();
                if (this.OriginalTotal != null)
                    hashCode = hashCode * 59 + this.OriginalTotal.GetHashCode();
                if (this.ConvertedTotal != null)
                    hashCode = hashCode * 59 + this.ConvertedTotal.GetHashCode();
                if (this.FundTransferDate != null)
                    hashCode = hashCode * 59 + this.FundTransferDate.GetHashCode();
                if (this.TraceId != null)
                    hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.AccountTail != null)
                    hashCode = hashCode * 59 + this.AccountTail.GetHashCode();
                if (this.BeginningBalance != null)
                    hashCode = hashCode * 59 + this.BeginningBalance.GetHashCode();
                if (this.FinancialEventGroupStart != null)
                    hashCode = hashCode * 59 + this.FinancialEventGroupStart.GetHashCode();
                if (this.FinancialEventGroupEnd != null)
                    hashCode = hashCode * 59 + this.FinancialEventGroupEnd.GetHashCode();
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
