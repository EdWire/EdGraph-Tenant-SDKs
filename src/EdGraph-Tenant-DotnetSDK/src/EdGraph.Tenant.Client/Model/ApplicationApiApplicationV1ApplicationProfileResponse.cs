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
    /// ApplicationApiApplicationV1ApplicationProfileResponse
    /// </summary>
    [DataContract(Name = "ApplicationApi.Application.V1.ApplicationProfileResponse")]
    public partial class ApplicationApiApplicationV1ApplicationProfileResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApplicationType
        /// </summary>
        [DataMember(Name = "applicationType", EmitDefaultValue = false)]
        public ApplicationApiApplicationV1ApplicationType? ApplicationType { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationStatus
        /// </summary>
        [DataMember(Name = "applicationStatus", EmitDefaultValue = false)]
        public ApplicationApiApplicationV1ApplicationStatus? ApplicationStatus { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionType
        /// </summary>
        [DataMember(Name = "subscriptionType", EmitDefaultValue = false)]
        public ApplicationApiApplicationV1ApplicationSubscriptionType? SubscriptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApiApplicationV1ApplicationProfileResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationType">applicationType.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="applicationUri">applicationUri.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="tooltipText">tooltipText.</param>
        /// <param name="applicationDescription">applicationDescription.</param>
        /// <param name="tags">tags.</param>
        /// <param name="groups">groups.</param>
        /// <param name="applicationStatus">applicationStatus.</param>
        /// <param name="openInNewWindow">openInNewWindow.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="subscriptionType">subscriptionType.</param>
        public ApplicationApiApplicationV1ApplicationProfileResponse(string tenantId = default(string), string applicationId = default(string), ApplicationApiApplicationV1ApplicationType? applicationType = default(ApplicationApiApplicationV1ApplicationType?), string applicationName = default(string), string applicationUri = default(string), string varVersion = default(string), string tooltipText = default(string), string applicationDescription = default(string), string tags = default(string), string groups = default(string), ApplicationApiApplicationV1ApplicationStatus? applicationStatus = default(ApplicationApiApplicationV1ApplicationStatus?), bool openInNewWindow = default(bool), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string), string clientId = default(string), ApplicationApiApplicationV1ApplicationSubscriptionType? subscriptionType = default(ApplicationApiApplicationV1ApplicationSubscriptionType?))
        {
            this.TenantId = tenantId;
            this.ApplicationId = applicationId;
            this.ApplicationType = applicationType;
            this.ApplicationName = applicationName;
            this.ApplicationUri = applicationUri;
            this.VarVersion = varVersion;
            this.TooltipText = tooltipText;
            this.ApplicationDescription = applicationDescription;
            this.Tags = tags;
            this.Groups = groups;
            this.ApplicationStatus = applicationStatus;
            this.OpenInNewWindow = openInNewWindow;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.ClientId = clientId;
            this.SubscriptionType = subscriptionType;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name = "applicationName", EmitDefaultValue = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationUri
        /// </summary>
        [DataMember(Name = "applicationUri", EmitDefaultValue = true)]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets TooltipText
        /// </summary>
        [DataMember(Name = "tooltipText", EmitDefaultValue = true)]
        public string TooltipText { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationDescription
        /// </summary>
        [DataMember(Name = "applicationDescription", EmitDefaultValue = true)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public string Groups { get; set; }

        /// <summary>
        /// Gets or Sets OpenInNewWindow
        /// </summary>
        [DataMember(Name = "openInNewWindow", EmitDefaultValue = true)]
        public bool OpenInNewWindow { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<ApplicationApiApplicationV1Role> Roles { get; private set; }

        /// <summary>
        /// Returns false as Roles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRoles()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = true)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = true)]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationApiApplicationV1ApplicationProfileResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  TooltipText: ").Append(TooltipText).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  ApplicationStatus: ").Append(ApplicationStatus).Append("\n");
            sb.Append("  OpenInNewWindow: ").Append(OpenInNewWindow).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
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
