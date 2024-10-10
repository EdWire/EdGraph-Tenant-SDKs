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
    /// EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantAdditionalSetting
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Requests.Tenants.TenantAdditionalSetting")]
    public partial class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantAdditionalSetting : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantAdditionalSetting" /> class.
        /// </summary>
        /// <param name="showLocalLoginOptionToTenantAdmins">showLocalLoginOptionToTenantAdmins.</param>
        /// <param name="gracePeriodMfaExpiryDate">gracePeriodMfaExpiryDate.</param>
        public EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantAdditionalSetting(bool? showLocalLoginOptionToTenantAdmins = default(bool?), DateTime gracePeriodMfaExpiryDate = default(DateTime))
        {
            this.ShowLocalLoginOptionToTenantAdmins = showLocalLoginOptionToTenantAdmins;
            this.GracePeriodMfaExpiryDate = gracePeriodMfaExpiryDate;
        }

        /// <summary>
        /// Gets or Sets ShowLocalLoginOptionToTenantAdmins
        /// </summary>
        [DataMember(Name = "showLocalLoginOptionToTenantAdmins", EmitDefaultValue = true)]
        public bool? ShowLocalLoginOptionToTenantAdmins { get; set; }

        /// <summary>
        /// Gets or Sets GracePeriodMfaExpiryDate
        /// </summary>
        [DataMember(Name = "gracePeriodMfaExpiryDate", EmitDefaultValue = false)]
        public DateTime GracePeriodMfaExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantAdditionalSetting {\n");
            sb.Append("  ShowLocalLoginOptionToTenantAdmins: ").Append(ShowLocalLoginOptionToTenantAdmins).Append("\n");
            sb.Append("  GracePeriodMfaExpiryDate: ").Append(GracePeriodMfaExpiryDate).Append("\n");
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
