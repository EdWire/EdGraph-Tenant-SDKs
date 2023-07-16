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
    /// TenantApiTenantV1InstanceDatabases
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.InstanceDatabases")]
    public partial class TenantApiTenantV1InstanceDatabases : IEquatable<TenantApiTenantV1InstanceDatabases>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1InstanceDatabases" /> class.
        /// </summary>
        /// <param name="admin">admin.</param>
        /// <param name="security">security.</param>
        public TenantApiTenantV1InstanceDatabases(TenantApiTenantV1InstanceDatabase admin = default(TenantApiTenantV1InstanceDatabase), TenantApiTenantV1InstanceDatabase security = default(TenantApiTenantV1InstanceDatabase))
        {
            this.Admin = admin;
            this.Security = security;
        }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public TenantApiTenantV1InstanceDatabase Admin { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public TenantApiTenantV1InstanceDatabase Security { get; set; }

        /// <summary>
        /// Gets or Sets Ods
        /// </summary>
        [DataMember(Name = "ods", EmitDefaultValue = true)]
        public List<TenantApiTenantV1InstanceOdsDatabase> Ods { get; private set; }

        /// <summary>
        /// Returns false as Ods should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOds()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1InstanceDatabases {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Ods: ").Append(Ods).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1InstanceDatabases);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1InstanceDatabases instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1InstanceDatabases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1InstanceDatabases input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Ods == input.Ods ||
                    this.Ods != null &&
                    input.Ods != null &&
                    this.Ods.SequenceEqual(input.Ods)
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
                if (this.Admin != null)
                {
                    hashCode = (hashCode * 59) + this.Admin.GetHashCode();
                }
                if (this.Security != null)
                {
                    hashCode = (hashCode * 59) + this.Security.GetHashCode();
                }
                if (this.Ods != null)
                {
                    hashCode = (hashCode * 59) + this.Ods.GetHashCode();
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