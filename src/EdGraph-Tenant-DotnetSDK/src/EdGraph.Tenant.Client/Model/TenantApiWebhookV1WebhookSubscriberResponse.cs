/*
 * Tenant Api
 *
 * Tenant Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdGraph.Tenant.Client.Client.OpenAPIDateConverter;

namespace EdGraph.Tenant.Client.Model
{
    /// <summary>
    /// Webhook Subscribers
    /// </summary>
    [DataContract(Name = "TenantApi.Webhook.V1.WebhookSubscriberResponse")]
    public partial class TenantApiWebhookV1WebhookSubscriberResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiWebhookV1WebhookSubscriberResponse" /> class.
        /// </summary>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventVersion">eventVersion.</param>
        /// <param name="eventSchema">eventSchema.</param>
        /// <param name="groupName">groupName.</param>
        public TenantApiWebhookV1WebhookSubscriberResponse(string eventName = default(string), string eventVersion = default(string), string eventSchema = default(string), string groupName = default(string))
        {
            this.EventName = eventName;
            this.EventVersion = eventVersion;
            this.EventSchema = eventSchema;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name = "eventName", EmitDefaultValue = true)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets EventVersion
        /// </summary>
        [DataMember(Name = "eventVersion", EmitDefaultValue = true)]
        public string EventVersion { get; set; }

        /// <summary>
        /// Gets or Sets EventSchema
        /// </summary>
        [DataMember(Name = "eventSchema", EmitDefaultValue = true)]
        public string EventSchema { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public List<string> Scope { get; private set; }

        /// <summary>
        /// Returns false as Scope should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScope()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiWebhookV1WebhookSubscriberResponse {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventVersion: ").Append(EventVersion).Append("\n");
            sb.Append("  EventSchema: ").Append(EventSchema).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
