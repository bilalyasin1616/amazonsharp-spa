/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.
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

namespace AmazonSharp.Models.Notifications
{
    /// <summary>
    /// Represents an Amazon EventBridge destination.
    /// </summary>
    [DataContract]
    public partial class EventBridgeResource : IEquatable<EventBridgeResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBridgeResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventBridgeResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBridgeResource" /> class.
        /// </summary>
        /// <param name="Name">The name of the partner event source associated with the destination. (required).</param>
        /// <param name="Region">The AWS region in which you receive the notifications. For AWS regions that are supported in Amazon EventBridge, see https://docs.aws.amazon.com/general/latest/gr/ev.html. (required).</param>
        /// <param name="AccountId">The identifier for the AWS account that is responsible for charges related to receiving notifications. (required).</param>
        public EventBridgeResource(string Name = default(string), string Region = default(string), string AccountId = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EventBridgeResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Region" is required (not null)
            if (Region == null)
            {
                throw new InvalidDataException("Region is a required property for EventBridgeResource and cannot be null");
            }
            else
            {
                this.Region = Region;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for EventBridgeResource and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
        }

        /// <summary>
        /// The name of the partner event source associated with the destination.
        /// </summary>
        /// <value>The name of the partner event source associated with the destination.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The AWS region in which you receive the notifications. For AWS regions that are supported in Amazon EventBridge, see https://docs.aws.amazon.com/general/latest/gr/ev.html.
        /// </summary>
        /// <value>The AWS region in which you receive the notifications. For AWS regions that are supported in Amazon EventBridge, see https://docs.aws.amazon.com/general/latest/gr/ev.html.</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// The identifier for the AWS account that is responsible for charges related to receiving notifications.
        /// </summary>
        /// <value>The identifier for the AWS account that is responsible for charges related to receiving notifications.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventBridgeResource {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(input as EventBridgeResource);
        }

        /// <summary>
        /// Returns true if EventBridgeResource instances are equal
        /// </summary>
        /// <param name="input">Instance of EventBridgeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventBridgeResource input)
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
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) &&
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
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
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new[] { "Name" });
            }

            yield break;
        }
    }

}
