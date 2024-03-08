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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationUrl
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.ApplicationUrl")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationUrl : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ApplicationApiApplicationV1UrlType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationUrl" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="label">label.</param>
        /// <param name="value">value.</param>
        /// <param name="openInNewTab">openInNewTab.</param>
        /// <param name="varReadonly">varReadonly.</param>
        /// <param name="type">type.</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationUrl(string code = default(string), string label = default(string), string value = default(string), bool openInNewTab = default(bool), bool varReadonly = default(bool), ApplicationApiApplicationV1UrlType? type = default(ApplicationApiApplicationV1UrlType?))
        {
            this.Code = code;
            this.Label = label;
            this.Value = value;
            this.OpenInNewTab = openInNewTab;
            this.VarReadonly = varReadonly;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets OpenInNewTab
        /// </summary>
        [DataMember(Name = "openInNewTab", EmitDefaultValue = true)]
        public bool OpenInNewTab { get; set; }

        /// <summary>
        /// Gets or Sets VarReadonly
        /// </summary>
        [DataMember(Name = "readonly", EmitDefaultValue = true)]
        public bool VarReadonly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationUrl {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  OpenInNewTab: ").Append(OpenInNewTab).Append("\n");
            sb.Append("  VarReadonly: ").Append(VarReadonly).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
