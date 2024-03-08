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
    /// EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesDomainListResponseDto
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.DomainListResponseDto")]
    public partial class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesDomainListResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DomainStatus
        /// </summary>
        [DataMember(Name = "domainStatus", EmitDefaultValue = false)]
        public TenantApiTenantV1DomainStatus? DomainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesDomainListResponseDto" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="domainName">domainName.</param>
        /// <param name="domainStatus">domainStatus.</param>
        /// <param name="autoAssignUsers">autoAssignUsers.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        public EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesDomainListResponseDto(string tenantId = default(string), string domainName = default(string), TenantApiTenantV1DomainStatus? domainStatus = default(TenantApiTenantV1DomainStatus?), bool autoAssignUsers = default(bool), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string))
        {
            this.TenantId = tenantId;
            this.DomainName = domainName;
            this.DomainStatus = domainStatus;
            this.AutoAssignUsers = autoAssignUsers;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets DomainName
        /// </summary>
        [DataMember(Name = "domainName", EmitDefaultValue = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets AutoAssignUsers
        /// </summary>
        [DataMember(Name = "autoAssignUsers", EmitDefaultValue = true)]
        public bool AutoAssignUsers { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesDomainListResponseDto {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  DomainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  AutoAssignUsers: ").Append(AutoAssignUsers).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
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
