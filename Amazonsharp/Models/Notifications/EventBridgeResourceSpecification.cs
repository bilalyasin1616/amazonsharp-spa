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
    /// The information required to create an Amazon EventBridge destination.
    /// </summary>
    [DataContract]
    public partial class EventBridgeResourceSpecification : IEquatable<EventBridgeResourceSpecification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBridgeResourceSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventBridgeResourceSpecification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBridgeResourceSpecification" /> class.
        /// </summary>
        /// <param name="Region">The AWS region in which you will be receiving the notifications. (required).</param>
        /// <param name="AccountId">The identifier for the AWS account that is responsible for charges related to receiving notifications. (required).</param>
        public EventBridgeResourceSpecification(string Region = default(string), string AccountId = default(string))
        {
            // to ensure "Region" is required (not null)
            if (Region == null)
            {
                throw new InvalidDataException("Region is a required property for EventBridgeResourceSpecification and cannot be null");
            }
            else
            {
                this.Region = Region;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for EventBridgeResourceSpecification and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
        }

        /// <summary>
        /// The AWS region in which you will be receiving the notifications.
        /// </summary>
        /// <value>The AWS region in which you will be receiving the notifications.</value>
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
            sb.Append("class EventBridgeResourceSpecification {\n");
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
            return this.Equals(input as EventBridgeResourceSpecification);
        }

        /// <summary>
        /// Returns true if EventBridgeResourceSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of EventBridgeResourceSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventBridgeResourceSpecification input)
        {
            if (input == null)
                return false;

            return
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
            yield break;
        }
    }

}
