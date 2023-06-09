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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.ApplicationRole")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole : IEquatable<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole" /> class.
        /// </summary>
        /// <param name="role">The role associated with the application.</param>
        /// <param name="isAssigned">Indicates if the user is assigned license for this application.</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole(string role = default(string), bool isAssigned = default(bool))
        {
            this.Role = role;
            this.IsAssigned = isAssigned;
        }

        /// <summary>
        /// The role associated with the application
        /// </summary>
        /// <value>The role associated with the application</value>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Indicates if the user is assigned license for this application
        /// </summary>
        /// <value>Indicates if the user is assigned license for this application</value>
        [DataMember(Name = "isAssigned", EmitDefaultValue = true)]
        public bool IsAssigned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  IsAssigned: ").Append(IsAssigned).Append("\n");
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
            return this.Equals(input as EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole);
        }

        /// <summary>
        /// Returns true if EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.IsAssigned == input.IsAssigned ||
                    this.IsAssigned.Equals(input.IsAssigned)
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
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAssigned.GetHashCode();
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
