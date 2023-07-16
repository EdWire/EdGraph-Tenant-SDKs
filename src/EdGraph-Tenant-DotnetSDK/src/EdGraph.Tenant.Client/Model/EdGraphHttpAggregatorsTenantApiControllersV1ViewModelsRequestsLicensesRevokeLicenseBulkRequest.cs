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
    /// EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Requests.Licenses.RevokeLicenseBulkRequest")]
    public partial class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest : IEquatable<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="revokeLicenseRequests">revokeLicenseRequests.</param>
        public EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest(string tenantId = default(string), string userId = default(string), List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseRequest> revokeLicenseRequests = default(List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseRequest>))
        {
            this.TenantId = tenantId;
            this.UserId = userId;
            this.RevokeLicenseRequests = revokeLicenseRequests;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets RevokeLicenseRequests
        /// </summary>
        [DataMember(Name = "revokeLicenseRequests", EmitDefaultValue = true)]
        public List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseRequest> RevokeLicenseRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RevokeLicenseRequests: ").Append(RevokeLicenseRequests).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesRevokeLicenseBulkRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.RevokeLicenseRequests == input.RevokeLicenseRequests ||
                    this.RevokeLicenseRequests != null &&
                    input.RevokeLicenseRequests != null &&
                    this.RevokeLicenseRequests.SequenceEqual(input.RevokeLicenseRequests)
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
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.RevokeLicenseRequests != null)
                {
                    hashCode = (hashCode * 59) + this.RevokeLicenseRequests.GetHashCode();
                }
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