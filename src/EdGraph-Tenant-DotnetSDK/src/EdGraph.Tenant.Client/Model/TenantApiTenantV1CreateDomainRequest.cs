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
    /// TenantApiTenantV1CreateDomainRequest
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.CreateDomainRequest")]
    public partial class TenantApiTenantV1CreateDomainRequest : IEquatable<TenantApiTenantV1CreateDomainRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DomainStatus
        /// </summary>
        [DataMember(Name = "domainStatus", EmitDefaultValue = false)]
        public TenantApiTenantV1DomainStatus? DomainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1CreateDomainRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="domainName">domainName.</param>
        /// <param name="domainStatus">domainStatus.</param>
        public TenantApiTenantV1CreateDomainRequest(string tenantId = default(string), string domainName = default(string), TenantApiTenantV1DomainStatus? domainStatus = default(TenantApiTenantV1DomainStatus?))
        {
            this.TenantId = tenantId;
            this.DomainName = domainName;
            this.DomainStatus = domainStatus;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1CreateDomainRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  DomainStatus: ").Append(DomainStatus).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1CreateDomainRequest);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1CreateDomainRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1CreateDomainRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1CreateDomainRequest input)
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
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.DomainStatus == input.DomainStatus ||
                    this.DomainStatus.Equals(input.DomainStatus)
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
                if (this.DomainName != null)
                {
                    hashCode = (hashCode * 59) + this.DomainName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DomainStatus.GetHashCode();
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
