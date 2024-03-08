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
    /// EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Requests.EducationOrganizations.AddEducationOrganizationRequest")]
    public partial class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="educationOrganizationId">educationOrganizationId.</param>
        /// <param name="staffClassifications">staffClassifications.</param>
        public EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest(string userId = default(string), string tenantId = default(string), int educationOrganizationId = default(int), List<string> staffClassifications = default(List<string>))
        {
            this.UserId = userId;
            this.TenantId = tenantId;
            this.EducationOrganizationId = educationOrganizationId;
            this.StaffClassifications = staffClassifications;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationId
        /// </summary>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets StaffClassifications
        /// </summary>
        [DataMember(Name = "staffClassifications", EmitDefaultValue = true)]
        public List<string> StaffClassifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  StaffClassifications: ").Append(StaffClassifications).Append("\n");
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