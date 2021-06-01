/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
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

namespace AmazonSharp.Models.Services
{
    /// <summary>
    /// Warning returned when the request is successful but execution have some important callouts on basis of which API clients should take defined actions.
    /// </summary>
    [DataContract]
    public partial class Warning : IEquatable<Warning>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Warning" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Warning() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Warning" /> class.
        /// </summary>
        /// <param name="Code">An warning code that identifies the type of warning that occurred. (required).</param>
        /// <param name="Message">A message that describes the warning condition in a human-readable form. (required).</param>
        /// <param name="Details">Additional details that can help the caller understand or address the warning..</param>
        public Warning(string Code = default(string), string Message = default(string), string Details = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Warning and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for Warning and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.Details = Details;
        }

        /// <summary>
        /// An warning code that identifies the type of warning that occurred.
        /// </summary>
        /// <value>An warning code that identifies the type of warning that occurred.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the warning condition in a human-readable form.
        /// </summary>
        /// <value>A message that describes the warning condition in a human-readable form.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Additional details that can help the caller understand or address the warning.
        /// </summary>
        /// <value>Additional details that can help the caller understand or address the warning.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Warning {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as Warning);
        }

        /// <summary>
        /// Returns true if Warning instances are equal
        /// </summary>
        /// <param name="input">Instance of Warning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Warning input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) &&
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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