/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace AmazonSharp.Models.MerchantFulfillment
{
    /// <summary>
    /// Specifies characteristics that apply to a seller input.
    /// </summary>
    [DataContract]
    public partial class SellerInputDefinition : IEquatable<SellerInputDefinition>, IValidatableObject
    {
        /// <summary>
        /// Whether the seller input applies to the item or the shipment.
        /// </summary>
        /// <value>Whether the seller input applies to the item or the shipment.</value>
        [DataMember(Name = "InputTarget", EmitDefaultValue = false)]
        public InputTargetType? InputTarget { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerInputDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SellerInputDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerInputDefinition" /> class.
        /// </summary>
        /// <param name="IsRequired">When true, the additional input field is required. (required).</param>
        /// <param name="DataType">The data type of the additional input field. (required).</param>
        /// <param name="Constraints">Constraints (required).</param>
        /// <param name="InputDisplayText">The display text for the additional input field. (required).</param>
        /// <param name="InputTarget">Whether the seller input applies to the item or the shipment..</param>
        /// <param name="StoredValue">StoredValue (required).</param>
        /// <param name="RestrictedSetValues">RestrictedSetValues.</param>
        public SellerInputDefinition(bool? IsRequired = default(bool?), string DataType = default(string), Constraints Constraints = default(Constraints), string InputDisplayText = default(string), InputTargetType? InputTarget = default(InputTargetType?), AdditionalSellerInput StoredValue = default(AdditionalSellerInput), RestrictedSetValues RestrictedSetValues = default(RestrictedSetValues))
        {
            // to ensure "IsRequired" is required (not null)
            if (IsRequired == null)
            {
                throw new InvalidDataException("IsRequired is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.IsRequired = IsRequired;
            }
            // to ensure "DataType" is required (not null)
            if (DataType == null)
            {
                throw new InvalidDataException("DataType is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.DataType = DataType;
            }
            // to ensure "Constraints" is required (not null)
            if (Constraints == null)
            {
                throw new InvalidDataException("Constraints is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.Constraints = Constraints;
            }
            // to ensure "InputDisplayText" is required (not null)
            if (InputDisplayText == null)
            {
                throw new InvalidDataException("InputDisplayText is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.InputDisplayText = InputDisplayText;
            }
            // to ensure "StoredValue" is required (not null)
            if (StoredValue == null)
            {
                throw new InvalidDataException("StoredValue is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.StoredValue = StoredValue;
            }
            this.InputTarget = InputTarget;
            this.RestrictedSetValues = RestrictedSetValues;
        }

        /// <summary>
        /// When true, the additional input field is required.
        /// </summary>
        /// <value>When true, the additional input field is required.</value>
        [DataMember(Name = "IsRequired", EmitDefaultValue = false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// The data type of the additional input field.
        /// </summary>
        /// <value>The data type of the additional input field.</value>
        [DataMember(Name = "DataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name = "Constraints", EmitDefaultValue = false)]
        public Constraints Constraints { get; set; }

        /// <summary>
        /// The display text for the additional input field.
        /// </summary>
        /// <value>The display text for the additional input field.</value>
        [DataMember(Name = "InputDisplayText", EmitDefaultValue = false)]
        public string InputDisplayText { get; set; }


        /// <summary>
        /// Gets or Sets StoredValue
        /// </summary>
        [DataMember(Name = "StoredValue", EmitDefaultValue = false)]
        public AdditionalSellerInput StoredValue { get; set; }

        /// <summary>
        /// Gets or Sets RestrictedSetValues
        /// </summary>
        [DataMember(Name = "RestrictedSetValues", EmitDefaultValue = false)]
        public RestrictedSetValues RestrictedSetValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SellerInputDefinition {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  InputDisplayText: ").Append(InputDisplayText).Append("\n");
            sb.Append("  InputTarget: ").Append(InputTarget).Append("\n");
            sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
            sb.Append("  RestrictedSetValues: ").Append(RestrictedSetValues).Append("\n");
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
            return this.Equals(input as SellerInputDefinition);
        }

        /// <summary>
        /// Returns true if SellerInputDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerInputDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerInputDefinition input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) &&
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) &&
                (
                    this.Constraints == input.Constraints ||
                    (this.Constraints != null &&
                    this.Constraints.Equals(input.Constraints))
                ) &&
                (
                    this.InputDisplayText == input.InputDisplayText ||
                    (this.InputDisplayText != null &&
                    this.InputDisplayText.Equals(input.InputDisplayText))
                ) &&
                (
                    this.InputTarget == input.InputTarget ||
                    (this.InputTarget != null &&
                    this.InputTarget.Equals(input.InputTarget))
                ) &&
                (
                    this.StoredValue == input.StoredValue ||
                    (this.StoredValue != null &&
                    this.StoredValue.Equals(input.StoredValue))
                ) &&
                (
                    this.RestrictedSetValues == input.RestrictedSetValues ||
                    (this.RestrictedSetValues != null &&
                    this.RestrictedSetValues.Equals(input.RestrictedSetValues))
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
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.InputDisplayText != null)
                    hashCode = hashCode * 59 + this.InputDisplayText.GetHashCode();
                if (this.InputTarget != null)
                    hashCode = hashCode * 59 + this.InputTarget.GetHashCode();
                if (this.StoredValue != null)
                    hashCode = hashCode * 59 + this.StoredValue.GetHashCode();
                if (this.RestrictedSetValues != null)
                    hashCode = hashCode * 59 + this.RestrictedSetValues.GetHashCode();
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
