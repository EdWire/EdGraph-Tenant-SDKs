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
    /// IdentityApiStaffClassificationV1UpdateStaffClassificationRequest
    /// </summary>
    [DataContract(Name = "IdentityApi.StaffClassification.V1.UpdateStaffClassificationRequest")]
    public partial class IdentityApiStaffClassificationV1UpdateStaffClassificationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiStaffClassificationV1UpdateStaffClassificationRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="codeValue">codeValue.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="description">description.</param>
        public IdentityApiStaffClassificationV1UpdateStaffClassificationRequest(string id = default(string), string varNamespace = default(string), string codeValue = default(string), string shortDescription = default(string), string description = default(string))
        {
            this.Id = id;
            this.VarNamespace = varNamespace;
            this.CodeValue = codeValue;
            this.ShortDescription = shortDescription;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Gets or Sets CodeValue
        /// </summary>
        [DataMember(Name = "codeValue", EmitDefaultValue = true)]
        public string CodeValue { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "shortDescription", EmitDefaultValue = true)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name = "licenses", EmitDefaultValue = true)]
        public List<IdentityApiStaffClassificationV1StaffClassificationLicenseRequest> Licenses { get; private set; }

        /// <summary>
        /// Returns false as Licenses should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLicenses()
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
            sb.Append("class IdentityApiStaffClassificationV1UpdateStaffClassificationRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Licenses: ").Append(Licenses).Append("\n");
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
