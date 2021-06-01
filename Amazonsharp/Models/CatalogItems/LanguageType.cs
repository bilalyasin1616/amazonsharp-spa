/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items helps you programmatically retrieve item details for items in the catalog.
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

namespace AmazonSharp.Models.CatalogItems
{
    /// <summary>
    /// The language type attribute of an item.
    /// </summary>
    [DataContract]
    public partial class LanguageType : IEquatable<LanguageType>, IValidatableObject
    {
        public LanguageType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageType" /> class.
        /// </summary>
        /// <param name="Name">The name attribute of the item..</param>
        /// <param name="Type">The type attribute of the item..</param>
        /// <param name="AudioFormat">The audio format attribute of the item..</param>
        public LanguageType(string Name = default(string), string Type = default(string), string AudioFormat = default(string))
        {
            this.Name = Name;
            this.Type = Type;
            this.AudioFormat = AudioFormat;
        }

        /// <summary>
        /// The name attribute of the item.
        /// </summary>
        /// <value>The name attribute of the item.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The type attribute of the item.
        /// </summary>
        /// <value>The type attribute of the item.</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The audio format attribute of the item.
        /// </summary>
        /// <value>The audio format attribute of the item.</value>
        [DataMember(Name = "AudioFormat", EmitDefaultValue = false)]
        public string AudioFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AudioFormat: ").Append(AudioFormat).Append("\n");
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
            return this.Equals(input as LanguageType);
        }

        /// <summary>
        /// Returns true if LanguageType instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) &&
                (
                    this.AudioFormat == input.AudioFormat ||
                    (this.AudioFormat != null &&
                    this.AudioFormat.Equals(input.AudioFormat))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AudioFormat != null)
                    hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
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
