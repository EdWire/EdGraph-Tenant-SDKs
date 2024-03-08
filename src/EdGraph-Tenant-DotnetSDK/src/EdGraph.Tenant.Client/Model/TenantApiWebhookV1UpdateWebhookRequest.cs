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
    /// TenantApiWebhookV1UpdateWebhookRequest
    /// </summary>
    [DataContract(Name = "TenantApi.Webhook.V1.UpdateWebhookRequest")]
    public partial class TenantApiWebhookV1UpdateWebhookRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiWebhookV1UpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="secretHeader">secretHeader.</param>
        /// <param name="secretValue">secretValue.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="status">status.</param>
        public TenantApiWebhookV1UpdateWebhookRequest(string id = default(string), string tenantId = default(string), string name = default(string), string url = default(string), string secretHeader = default(string), string secretValue = default(string), string contentType = default(string), string status = default(string))
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.Name = name;
            this.Url = url;
            this.SecretHeader = secretHeader;
            this.SecretValue = secretValue;
            this.ContentType = contentType;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SecretHeader
        /// </summary>
        [DataMember(Name = "secretHeader", EmitDefaultValue = true)]
        public string SecretHeader { get; set; }

        /// <summary>
        /// Gets or Sets SecretValue
        /// </summary>
        [DataMember(Name = "secretValue", EmitDefaultValue = true)]
        public string SecretValue { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EventSubscriptions
        /// </summary>
        [DataMember(Name = "eventSubscriptions", EmitDefaultValue = true)]
        public List<TenantApiWebhookV1WebhookSubscriberResponse> EventSubscriptions { get; private set; }

        /// <summary>
        /// Returns false as EventSubscriptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEventSubscriptions()
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
            sb.Append("class TenantApiWebhookV1UpdateWebhookRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SecretHeader: ").Append(SecretHeader).Append("\n");
            sb.Append("  SecretValue: ").Append(SecretValue).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventSubscriptions: ").Append(EventSubscriptions).Append("\n");
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
