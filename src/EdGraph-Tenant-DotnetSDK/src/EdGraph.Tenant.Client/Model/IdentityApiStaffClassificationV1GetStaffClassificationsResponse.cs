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
    /// IdentityApiStaffClassificationV1GetStaffClassificationsResponse
    /// </summary>
    [DataContract(Name = "IdentityApi.StaffClassification.V1.GetStaffClassificationsResponse")]
    public partial class IdentityApiStaffClassificationV1GetStaffClassificationsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApiStaffClassificationV1GetStaffClassificationsResponse" /> class.
        /// </summary>
        /// <param name="pageIndex">pageIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="count">count.</param>
        public IdentityApiStaffClassificationV1GetStaffClassificationsResponse(int pageIndex = default(int), int pageSize = default(int), long count = default(long))
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.Count = count;
        }

        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name = "pageIndex", EmitDefaultValue = false)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<IdentityApiStaffClassificationV1StaffClassificationResponse> Data { get; private set; }

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
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
            sb.Append("class IdentityApiStaffClassificationV1GetStaffClassificationsResponse {\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
