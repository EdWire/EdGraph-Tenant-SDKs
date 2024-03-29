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
    /// IdentityApiApiClientV1CreateApiClientRequest
    /// </summary>
    [DataContract(Name = "IdentityApi.ApiClient.V1.CreateApiClientRequest")]
    public partial class IdentityApiApiClientV1CreateApiClientRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiApiClientV1CreateApiClientRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="secretExpirationDateTime">secretExpirationDateTime.</param>
        public IdentityApiApiClientV1CreateApiClientRequest(string tenantId = default(string), string clientName = default(string), bool enabled = default(bool), string secretExpirationDateTime = default(string))
        {
            this.TenantId = tenantId;
            this.ClientName = clientName;
            this.Enabled = enabled;
            this.SecretExpirationDateTime = secretExpirationDateTime;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name = "clientName", EmitDefaultValue = true)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ApiClaims
        /// </summary>
        [DataMember(Name = "apiClaims", EmitDefaultValue = true)]
        public List<IdentityApiApiClientV1ApiClaim> ApiClaims { get; private set; }

        /// <summary>
        /// Returns false as ApiClaims should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiClaims()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SecretExpirationDateTime
        /// </summary>
        [DataMember(Name = "secretExpirationDateTime", EmitDefaultValue = true)]
        public string SecretExpirationDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityApiApiClientV1CreateApiClientRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ApiClaims: ").Append(ApiClaims).Append("\n");
            sb.Append("  SecretExpirationDateTime: ").Append(SecretExpirationDateTime).Append("\n");
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
