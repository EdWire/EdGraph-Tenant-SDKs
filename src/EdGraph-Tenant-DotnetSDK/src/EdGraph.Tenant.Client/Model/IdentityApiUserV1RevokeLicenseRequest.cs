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
    /// IdentityApiUserV1RevokeLicenseRequest
    /// </summary>
    [DataContract(Name = "IdentityApi.User.V1.RevokeLicenseRequest")]
    public partial class IdentityApiUserV1RevokeLicenseRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", EmitDefaultValue = false)]
        public IdentityApiUserV1RevokeStrategy? Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiUserV1RevokeLicenseRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="strategy">strategy.</param>
        public IdentityApiUserV1RevokeLicenseRequest(string tenantId = default(string), string subscriptionId = default(string), string applicationId = default(string), string userId = default(string), IdentityApiUserV1RevokeStrategy? strategy = default(IdentityApiUserV1RevokeStrategy?))
        {
            this.TenantId = tenantId;
            this.SubscriptionId = subscriptionId;
            this.ApplicationId = applicationId;
            this.UserId = userId;
            this.Strategy = strategy;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityApiUserV1RevokeLicenseRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
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
