/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
 *
 * OpenAPI spec version: v1
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

namespace AmazonSharp.Models.Shipping
{
    /// <summary>
    /// Item in the container.
    /// </summary>
    [DataContract]
    public partial class ContainerItem : IEquatable<ContainerItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContainerItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerItem" /> class.
        /// </summary>
        /// <param name="Quantity">The quantity of the items of this type in the container. (required).</param>
        /// <param name="UnitPrice">The unit price of an item of this type (the total value of this item type in the container is unitPrice * quantity). (required).</param>
        /// <param name="UnitWeight">The unit weight of an item of this type (the total weight of this item type in the container is unitWeight * quantity). (required).</param>
        /// <param name="Title">A descriptive title of the item. (required).</param>
        public ContainerItem(decimal? Quantity = default(decimal?), Currency UnitPrice = default(Currency), Weight UnitWeight = default(Weight), string Title = default(string))
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for ContainerItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "UnitPrice" is required (not null)
            if (UnitPrice == null)
            {
                throw new InvalidDataException("UnitPrice is a required property for ContainerItem and cannot be null");
            }
            else
            {
                this.UnitPrice = UnitPrice;
            }
            // to ensure "UnitWeight" is required (not null)
            if (UnitWeight == null)
            {
                throw new InvalidDataException("UnitWeight is a required property for ContainerItem and cannot be null");
            }
            else
            {
                this.UnitWeight = UnitWeight;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ContainerItem and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
        }

        /// <summary>
        /// The quantity of the items of this type in the container.
        /// </summary>
        /// <value>The quantity of the items of this type in the container.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The unit price of an item of this type (the total value of this item type in the container is unitPrice * quantity).
        /// </summary>
        /// <value>The unit price of an item of this type (the total value of this item type in the container is unitPrice * quantity).</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public Currency UnitPrice { get; set; }

        /// <summary>
        /// The unit weight of an item of this type (the total weight of this item type in the container is unitWeight * quantity).
        /// </summary>
        /// <value>The unit weight of an item of this type (the total weight of this item type in the container is unitWeight * quantity).</value>
        [DataMember(Name = "unitWeight", EmitDefaultValue = false)]
        public Weight UnitWeight { get; set; }

        /// <summary>
        /// A descriptive title of the item.
        /// </summary>
        /// <value>A descriptive title of the item.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerItem {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitWeight: ").Append(UnitWeight).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ContainerItem);
        }

        /// <summary>
        /// Returns true if ContainerItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) &&
                (
                    this.UnitWeight == input.UnitWeight ||
                    (this.UnitWeight != null &&
                    this.UnitWeight.Equals(input.UnitWeight))
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UnitWeight != null)
                    hashCode = hashCode * 59 + this.UnitWeight.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 30.", new[] { "Title" });
            }

            yield break;
        }
    }

}
