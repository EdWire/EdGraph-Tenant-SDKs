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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.UserLicense")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense : IEquatable<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense" /> class.
        /// </summary>
        /// <param name="subscriptionTenantId">The Tenant Id the subscription belongs to.</param>
        /// <param name="isTenantSubscribed">The Tenant has a subscription license for this application.</param>
        /// <param name="tenantSubscriptionId">The Tenant subscription Id.</param>
        /// <param name="tenantSubscriptionStartDateTime">The Tenant subscription start date.</param>
        /// <param name="tenantSubscriptionEndDateTime">The Tenant subscription end date.</param>
        /// <param name="tenantSubscriptionActualEndDateTime">The Tenant subscription end date.</param>
        /// <param name="numberOfLicenses">The Tenant&#39;s number of licenses.</param>
        /// <param name="assignedLicenses">The Tenant&#39;s assigned of licenses.</param>
        /// <param name="isUserLicensed">The user is assigned license for this application.</param>
        /// <param name="applicationTenantId">The Tenant this application belongs to.</param>
        /// <param name="applicationId">The application Id of the application for license.</param>
        /// <param name="applicationName">The application Name of the application for license.</param>
        /// <param name="applicationRole">Application role for this user..</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense(string subscriptionTenantId = default(string), bool isTenantSubscribed = default(bool), string tenantSubscriptionId = default(string), string tenantSubscriptionStartDateTime = default(string), string tenantSubscriptionEndDateTime = default(string), string tenantSubscriptionActualEndDateTime = default(string), int numberOfLicenses = default(int), int assignedLicenses = default(int), bool isUserLicensed = default(bool), string applicationTenantId = default(string), string applicationId = default(string), string applicationName = default(string), List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole> applicationRole = default(List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole>))
        {
            this.SubscriptionTenantId = subscriptionTenantId;
            this.IsTenantSubscribed = isTenantSubscribed;
            this.TenantSubscriptionId = tenantSubscriptionId;
            this.TenantSubscriptionStartDateTime = tenantSubscriptionStartDateTime;
            this.TenantSubscriptionEndDateTime = tenantSubscriptionEndDateTime;
            this.TenantSubscriptionActualEndDateTime = tenantSubscriptionActualEndDateTime;
            this.NumberOfLicenses = numberOfLicenses;
            this.AssignedLicenses = assignedLicenses;
            this.IsUserLicensed = isUserLicensed;
            this.ApplicationTenantId = applicationTenantId;
            this.ApplicationId = applicationId;
            this.ApplicationName = applicationName;
            this.ApplicationRole = applicationRole;
        }

        /// <summary>
        /// The Tenant Id the subscription belongs to
        /// </summary>
        /// <value>The Tenant Id the subscription belongs to</value>
        [DataMember(Name = "subscriptionTenantId", EmitDefaultValue = true)]
        public string SubscriptionTenantId { get; set; }

        /// <summary>
        /// The Tenant has a subscription license for this application
        /// </summary>
        /// <value>The Tenant has a subscription license for this application</value>
        [DataMember(Name = "isTenantSubscribed", EmitDefaultValue = true)]
        public bool IsTenantSubscribed { get; set; }

        /// <summary>
        /// The Tenant subscription Id
        /// </summary>
        /// <value>The Tenant subscription Id</value>
        [DataMember(Name = "tenantSubscriptionId", EmitDefaultValue = true)]
        public string TenantSubscriptionId { get; set; }

        /// <summary>
        /// The Tenant subscription start date
        /// </summary>
        /// <value>The Tenant subscription start date</value>
        [DataMember(Name = "tenantSubscriptionStartDateTime", EmitDefaultValue = true)]
        public string TenantSubscriptionStartDateTime { get; set; }

        /// <summary>
        /// The Tenant subscription end date
        /// </summary>
        /// <value>The Tenant subscription end date</value>
        [DataMember(Name = "tenantSubscriptionEndDateTime", EmitDefaultValue = true)]
        public string TenantSubscriptionEndDateTime { get; set; }

        /// <summary>
        /// The Tenant subscription end date
        /// </summary>
        /// <value>The Tenant subscription end date</value>
        [DataMember(Name = "tenantSubscriptionActualEndDateTime", EmitDefaultValue = true)]
        public string TenantSubscriptionActualEndDateTime { get; set; }

        /// <summary>
        /// The Tenant&#39;s number of licenses
        /// </summary>
        /// <value>The Tenant&#39;s number of licenses</value>
        [DataMember(Name = "numberOfLicenses", EmitDefaultValue = false)]
        public int NumberOfLicenses { get; set; }

        /// <summary>
        /// The Tenant&#39;s assigned of licenses
        /// </summary>
        /// <value>The Tenant&#39;s assigned of licenses</value>
        [DataMember(Name = "assignedLicenses", EmitDefaultValue = false)]
        public int AssignedLicenses { get; set; }

        /// <summary>
        /// The user is assigned license for this application
        /// </summary>
        /// <value>The user is assigned license for this application</value>
        [DataMember(Name = "isUserLicensed", EmitDefaultValue = true)]
        public bool IsUserLicensed { get; set; }

        /// <summary>
        /// The Tenant this application belongs to
        /// </summary>
        /// <value>The Tenant this application belongs to</value>
        [DataMember(Name = "applicationTenantId", EmitDefaultValue = true)]
        public string ApplicationTenantId { get; set; }

        /// <summary>
        /// The application Id of the application for license
        /// </summary>
        /// <value>The application Id of the application for license</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The application Name of the application for license
        /// </summary>
        /// <value>The application Name of the application for license</value>
        [DataMember(Name = "applicationName", EmitDefaultValue = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Application role for this user.
        /// </summary>
        /// <value>Application role for this user.</value>
        [DataMember(Name = "applicationRole", EmitDefaultValue = true)]
        public List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationRole> ApplicationRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense {\n");
            sb.Append("  SubscriptionTenantId: ").Append(SubscriptionTenantId).Append("\n");
            sb.Append("  IsTenantSubscribed: ").Append(IsTenantSubscribed).Append("\n");
            sb.Append("  TenantSubscriptionId: ").Append(TenantSubscriptionId).Append("\n");
            sb.Append("  TenantSubscriptionStartDateTime: ").Append(TenantSubscriptionStartDateTime).Append("\n");
            sb.Append("  TenantSubscriptionEndDateTime: ").Append(TenantSubscriptionEndDateTime).Append("\n");
            sb.Append("  TenantSubscriptionActualEndDateTime: ").Append(TenantSubscriptionActualEndDateTime).Append("\n");
            sb.Append("  NumberOfLicenses: ").Append(NumberOfLicenses).Append("\n");
            sb.Append("  AssignedLicenses: ").Append(AssignedLicenses).Append("\n");
            sb.Append("  IsUserLicensed: ").Append(IsUserLicensed).Append("\n");
            sb.Append("  ApplicationTenantId: ").Append(ApplicationTenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationRole: ").Append(ApplicationRole).Append("\n");
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
            return this.Equals(input as EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense);
        }

        /// <summary>
        /// Returns true if EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicense input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriptionTenantId == input.SubscriptionTenantId ||
                    (this.SubscriptionTenantId != null &&
                    this.SubscriptionTenantId.Equals(input.SubscriptionTenantId))
                ) && 
                (
                    this.IsTenantSubscribed == input.IsTenantSubscribed ||
                    this.IsTenantSubscribed.Equals(input.IsTenantSubscribed)
                ) && 
                (
                    this.TenantSubscriptionId == input.TenantSubscriptionId ||
                    (this.TenantSubscriptionId != null &&
                    this.TenantSubscriptionId.Equals(input.TenantSubscriptionId))
                ) && 
                (
                    this.TenantSubscriptionStartDateTime == input.TenantSubscriptionStartDateTime ||
                    (this.TenantSubscriptionStartDateTime != null &&
                    this.TenantSubscriptionStartDateTime.Equals(input.TenantSubscriptionStartDateTime))
                ) && 
                (
                    this.TenantSubscriptionEndDateTime == input.TenantSubscriptionEndDateTime ||
                    (this.TenantSubscriptionEndDateTime != null &&
                    this.TenantSubscriptionEndDateTime.Equals(input.TenantSubscriptionEndDateTime))
                ) && 
                (
                    this.TenantSubscriptionActualEndDateTime == input.TenantSubscriptionActualEndDateTime ||
                    (this.TenantSubscriptionActualEndDateTime != null &&
                    this.TenantSubscriptionActualEndDateTime.Equals(input.TenantSubscriptionActualEndDateTime))
                ) && 
                (
                    this.NumberOfLicenses == input.NumberOfLicenses ||
                    this.NumberOfLicenses.Equals(input.NumberOfLicenses)
                ) && 
                (
                    this.AssignedLicenses == input.AssignedLicenses ||
                    this.AssignedLicenses.Equals(input.AssignedLicenses)
                ) && 
                (
                    this.IsUserLicensed == input.IsUserLicensed ||
                    this.IsUserLicensed.Equals(input.IsUserLicensed)
                ) && 
                (
                    this.ApplicationTenantId == input.ApplicationTenantId ||
                    (this.ApplicationTenantId != null &&
                    this.ApplicationTenantId.Equals(input.ApplicationTenantId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.ApplicationRole == input.ApplicationRole ||
                    this.ApplicationRole != null &&
                    input.ApplicationRole != null &&
                    this.ApplicationRole.SequenceEqual(input.ApplicationRole)
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
                if (this.SubscriptionTenantId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionTenantId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsTenantSubscribed.GetHashCode();
                if (this.TenantSubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantSubscriptionId.GetHashCode();
                }
                if (this.TenantSubscriptionStartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.TenantSubscriptionStartDateTime.GetHashCode();
                }
                if (this.TenantSubscriptionEndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.TenantSubscriptionEndDateTime.GetHashCode();
                }
                if (this.TenantSubscriptionActualEndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.TenantSubscriptionActualEndDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumberOfLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.AssignedLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.IsUserLicensed.GetHashCode();
                if (this.ApplicationTenantId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationTenantId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.ApplicationName != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationName.GetHashCode();
                }
                if (this.ApplicationRole != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationRole.GetHashCode();
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
