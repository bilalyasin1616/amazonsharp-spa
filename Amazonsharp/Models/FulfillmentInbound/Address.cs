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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="Name">Name of the individual or business. (required).</param>
        /// <param name="AddressLine1">The street address information. (required).</param>
        /// <param name="AddressLine2">Additional street address information, if required..</param>
        /// <param name="DistrictOrCounty">The district or county..</param>
        /// <param name="City">The city. (required).</param>
        /// <param name="StateOrProvinceCode">The state or province code.  If state or province codes are used in your marketplace, it is recommended that you include one with your request. This helps Amazon to select the most appropriate Amazon fulfillment center for your inbound shipment plan. (required).</param>
        /// <param name="CountryCode">The country code in two-character ISO 3166-1 alpha-2 format. (required).</param>
        /// <param name="PostalCode">The postal code.  If postal codes are used in your marketplace, we recommended that you include one with your request. This helps Amazon select the most appropriate Amazon fulfillment center for the inbound shipment plan. (required).</param>
        public Address(string Name = default(string), string AddressLine1 = default(string), string AddressLine2 = default(string), string DistrictOrCounty = default(string), string City = default(string), string StateOrProvinceCode = default(string), string CountryCode = default(string), string PostalCode = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Address and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "AddressLine1" is required (not null)
            if (AddressLine1 == null)
            {
                throw new InvalidDataException("AddressLine1 is a required property for Address and cannot be null");
            }
            else
            {
                this.AddressLine1 = AddressLine1;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for Address and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "StateOrProvinceCode" is required (not null)
            if (StateOrProvinceCode == null)
            {
                throw new InvalidDataException("StateOrProvinceCode is a required property for Address and cannot be null");
            }
            else
            {
                this.StateOrProvinceCode = StateOrProvinceCode;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for Address and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            this.AddressLine2 = AddressLine2;
            this.DistrictOrCounty = DistrictOrCounty;
        }

        /// <summary>
        /// Name of the individual or business.
        /// </summary>
        /// <value>Name of the individual or business.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The street address information.
        /// </summary>
        /// <value>The street address information.</value>
        [DataMember(Name = "AddressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        /// <value>Additional street address information, if required.</value>
        [DataMember(Name = "AddressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The district or county.
        /// </summary>
        /// <value>The district or county.</value>
        [DataMember(Name = "DistrictOrCounty", EmitDefaultValue = false)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state or province code.  If state or province codes are used in your marketplace, it is recommended that you include one with your request. This helps Amazon to select the most appropriate Amazon fulfillment center for your inbound shipment plan.
        /// </summary>
        /// <value>The state or province code.  If state or province codes are used in your marketplace, it is recommended that you include one with your request. This helps Amazon to select the most appropriate Amazon fulfillment center for your inbound shipment plan.</value>
        [DataMember(Name = "StateOrProvinceCode", EmitDefaultValue = false)]
        public string StateOrProvinceCode { get; set; }

        /// <summary>
        /// The country code in two-character ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The country code in two-character ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name = "CountryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The postal code.  If postal codes are used in your marketplace, we recommended that you include one with your request. This helps Amazon select the most appropriate Amazon fulfillment center for the inbound shipment plan.
        /// </summary>
        /// <value>The postal code.  If postal codes are used in your marketplace, we recommended that you include one with your request. This helps Amazon select the most appropriate Amazon fulfillment center for the inbound shipment plan.</value>
        [DataMember(Name = "PostalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  DistrictOrCounty: ").Append(DistrictOrCounty).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateOrProvinceCode: ").Append(StateOrProvinceCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
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
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) &&
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) &&
                (
                    this.DistrictOrCounty == input.DistrictOrCounty ||
                    (this.DistrictOrCounty != null &&
                    this.DistrictOrCounty.Equals(input.DistrictOrCounty))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.StateOrProvinceCode == input.StateOrProvinceCode ||
                    (this.StateOrProvinceCode != null &&
                    this.StateOrProvinceCode.Equals(input.StateOrProvinceCode))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.DistrictOrCounty != null)
                    hashCode = hashCode * 59 + this.DistrictOrCounty.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateOrProvinceCode != null)
                    hashCode = hashCode * 59 + this.StateOrProvinceCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new[] { "Name" });
            }

            // AddressLine1 (string) maxLength
            if (this.AddressLine1 != null && this.AddressLine1.Length > 180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 180.", new[] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if (this.AddressLine2 != null && this.AddressLine2.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 60.", new[] { "AddressLine2" });
            }

            // DistrictOrCounty (string) maxLength
            if (this.DistrictOrCounty != null && this.DistrictOrCounty.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistrictOrCounty, length must be less than 25.", new[] { "DistrictOrCounty" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new[] { "City" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 30.", new[] { "PostalCode" });
            }

            yield break;
        }
    }

}
