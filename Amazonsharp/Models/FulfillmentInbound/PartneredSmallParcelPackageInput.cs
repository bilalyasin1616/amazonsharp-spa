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
    /// Dimension and weight information for the package.
    /// </summary>
    [DataContract]
    public partial class PartneredSmallParcelPackageInput : IEquatable<PartneredSmallParcelPackageInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredSmallParcelPackageInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartneredSmallParcelPackageInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredSmallParcelPackageInput" /> class.
        /// </summary>
        /// <param name="Dimensions">Dimensions (required).</param>
        /// <param name="Weight">Weight (required).</param>
        public PartneredSmallParcelPackageInput(Dimensions Dimensions = default(Dimensions), Weight Weight = default(Weight))
        {
            // to ensure "Dimensions" is required (not null)
            if (Dimensions == null)
            {
                throw new InvalidDataException("Dimensions is a required property for PartneredSmallParcelPackageInput and cannot be null");
            }
            else
            {
                this.Dimensions = Dimensions;
            }
            // to ensure "Weight" is required (not null)
            if (Weight == null)
            {
                throw new InvalidDataException("Weight is a required property for PartneredSmallParcelPackageInput and cannot be null");
            }
            else
            {
                this.Weight = Weight;
            }
        }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "Dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredSmallParcelPackageInput {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as PartneredSmallParcelPackageInput);
        }

        /// <summary>
        /// Returns true if PartneredSmallParcelPackageInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredSmallParcelPackageInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredSmallParcelPackageInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
