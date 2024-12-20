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
    /// TenantApiPartnershipV1ParternshipTenantResponse
    /// </summary>
    [DataContract(Name = "TenantApi.Partnership.V1.ParternshipTenantResponse")]
    public partial class TenantApiPartnershipV1ParternshipTenantResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiPartnershipV1ParternshipTenantResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="organizationIdentifier">organizationIdentifier.</param>
        /// <param name="organizationName">organizationName.</param>
        public TenantApiPartnershipV1ParternshipTenantResponse(string tenantId = default(string), string organizationIdentifier = default(string), string organizationName = default(string))
        {
            this.TenantId = tenantId;
            this.OrganizationIdentifier = organizationIdentifier;
            this.OrganizationName = organizationName;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets TenantTypes
        /// </summary>
        [DataMember(Name = "tenantTypes", EmitDefaultValue = true)]
        public List<TenantApiPartnershipV1TenantType> TenantTypes { get; private set; }

        /// <summary>
        /// Returns false as TenantTypes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTenantTypes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OrganizationIdentifier
        /// </summary>
        [DataMember(Name = "organizationIdentifier", EmitDefaultValue = true)]
        public string OrganizationIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name = "organizationName", EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiPartnershipV1ParternshipTenantResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TenantTypes: ").Append(TenantTypes).Append("\n");
            sb.Append("  OrganizationIdentifier: ").Append(OrganizationIdentifier).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
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
