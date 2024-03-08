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
    /// TenantApiWebhookV1WebhookResponse
    /// </summary>
    [DataContract(Name = "TenantApi.Webhook.V1.WebhookResponse")]
    public partial class TenantApiWebhookV1WebhookResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiWebhookV1WebhookResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="secretHeader">secretHeader.</param>
        /// <param name="secretValue">secretValue.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="status">status.</param>
        public TenantApiWebhookV1WebhookResponse(string id = default(string), string tenantId = default(string), string createdAt = default(string), string createdBy = default(string), string updatedAt = default(string), string updatedBy = default(string), bool isDeleted = default(bool), string name = default(string), string url = default(string), string secretHeader = default(string), string secretValue = default(string), string contentType = default(string), string status = default(string))
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.IsDeleted = isDeleted;
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
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = true)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

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
            sb.Append("class TenantApiWebhookV1WebhookResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
