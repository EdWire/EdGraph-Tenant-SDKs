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
    /// TenantApiTenantV1SetAppSettingsResponse
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.SetAppSettingsResponse")]
    public partial class TenantApiTenantV1SetAppSettingsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1SetAppSettingsResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="code">code.</param>
        public TenantApiTenantV1SetAppSettingsResponse(string tenantId = default(string), string clientId = default(string), string code = default(string))
        {
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.Code = code;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1SetAppSettingsResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
