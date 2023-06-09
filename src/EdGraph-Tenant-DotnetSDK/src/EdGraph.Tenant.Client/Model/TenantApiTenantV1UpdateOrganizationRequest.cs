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
    /// TenantApiTenantV1UpdateOrganizationRequest
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.UpdateOrganizationRequest")]
    public partial class TenantApiTenantV1UpdateOrganizationRequest : IEquatable<TenantApiTenantV1UpdateOrganizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1UpdateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="identifierValue">identifierValue.</param>
        /// <param name="discriminator">discriminator.</param>
        /// <param name="source">source.</param>
        /// <param name="includeInJwt">includeInJwt.</param>
        public TenantApiTenantV1UpdateOrganizationRequest(string tenantId = default(string), string identifierValue = default(string), string discriminator = default(string), string source = default(string), bool includeInJwt = default(bool))
        {
            this.TenantId = tenantId;
            this.IdentifierValue = identifierValue;
            this.Discriminator = discriminator;
            this.Source = source;
            this.IncludeInJwt = includeInJwt;
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
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", EmitDefaultValue = true)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets IncludeInJwt
        /// </summary>
        [DataMember(Name = "includeInJwt", EmitDefaultValue = true)]
        public bool IncludeInJwt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1UpdateOrganizationRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  IdentifierValue: ").Append(IdentifierValue).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  IncludeInJwt: ").Append(IncludeInJwt).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1UpdateOrganizationRequest);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1UpdateOrganizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1UpdateOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1UpdateOrganizationRequest input)
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
                    this.IdentifierValue == input.IdentifierValue ||
                    (this.IdentifierValue != null &&
                    this.IdentifierValue.Equals(input.IdentifierValue))
                ) && 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.IncludeInJwt == input.IncludeInJwt ||
                    this.IncludeInJwt.Equals(input.IncludeInJwt)
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
                if (this.IdentifierValue != null)
                {
                    hashCode = (hashCode * 59) + this.IdentifierValue.GetHashCode();
                }
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeInJwt.GetHashCode();
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
