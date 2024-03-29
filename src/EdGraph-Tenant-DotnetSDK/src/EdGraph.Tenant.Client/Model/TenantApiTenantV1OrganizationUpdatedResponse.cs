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
    /// TenantApiTenantV1OrganizationUpdatedResponse
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.OrganizationUpdatedResponse")]
    public partial class TenantApiTenantV1OrganizationUpdatedResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1OrganizationUpdatedResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="identifierValue">identifierValue.</param>
        public TenantApiTenantV1OrganizationUpdatedResponse(string tenantId = default(string), string identifierValue = default(string))
        {
            this.TenantId = tenantId;
            this.IdentifierValue = identifierValue;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierValue
        /// </summary>
        [DataMember(Name = "identifierValue", EmitDefaultValue = true)]
        public string IdentifierValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1OrganizationUpdatedResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  IdentifierValue: ").Append(IdentifierValue).Append("\n");
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
