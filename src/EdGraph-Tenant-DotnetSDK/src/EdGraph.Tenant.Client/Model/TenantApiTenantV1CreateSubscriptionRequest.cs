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
    /// TenantApiTenantV1CreateSubscriptionRequest
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.CreateSubscriptionRequest")]
    public partial class TenantApiTenantV1CreateSubscriptionRequest : IEquatable<TenantApiTenantV1CreateSubscriptionRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LicenseType
        /// </summary>
        [DataMember(Name = "licenseType", EmitDefaultValue = false)]
        public TenantApiTenantV1LicenseType? LicenseType { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionStatus
        /// </summary>
        [DataMember(Name = "subscriptionStatus", EmitDefaultValue = false)]
        public TenantApiTenantV1SubscriptionStatus? SubscriptionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="gracePeriod">gracePeriod.</param>
        /// <param name="numberOfLicenses">numberOfLicenses.</param>
        /// <param name="assignedLicenses">assignedLicenses.</param>
        /// <param name="licenseType">licenseType.</param>
        /// <param name="subscriptionStatus">subscriptionStatus.</param>
        /// <param name="autoAssign">autoAssign.</param>
        public TenantApiTenantV1CreateSubscriptionRequest(string tenantId = default(string), string subscriptionId = default(string), string applicationId = default(string), string startDateTime = default(string), string endDateTime = default(string), int gracePeriod = default(int), int numberOfLicenses = default(int), int assignedLicenses = default(int), TenantApiTenantV1LicenseType? licenseType = default(TenantApiTenantV1LicenseType?), TenantApiTenantV1SubscriptionStatus? subscriptionStatus = default(TenantApiTenantV1SubscriptionStatus?), bool autoAssign = default(bool))
        {
            this.TenantId = tenantId;
            this.SubscriptionId = subscriptionId;
            this.ApplicationId = applicationId;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.GracePeriod = gracePeriod;
            this.NumberOfLicenses = numberOfLicenses;
            this.AssignedLicenses = assignedLicenses;
            this.LicenseType = licenseType;
            this.SubscriptionStatus = subscriptionStatus;
            this.AutoAssign = autoAssign;
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
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name = "startDateTime", EmitDefaultValue = true)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = true)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets GracePeriod
        /// </summary>
        [DataMember(Name = "gracePeriod", EmitDefaultValue = false)]
        public int GracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfLicenses
        /// </summary>
        [DataMember(Name = "numberOfLicenses", EmitDefaultValue = false)]
        public int NumberOfLicenses { get; set; }

        /// <summary>
        /// Gets or Sets AssignedLicenses
        /// </summary>
        [DataMember(Name = "assignedLicenses", EmitDefaultValue = false)]
        public int AssignedLicenses { get; set; }

        /// <summary>
        /// Gets or Sets AutoAssign
        /// </summary>
        [DataMember(Name = "autoAssign", EmitDefaultValue = true)]
        public bool AutoAssign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1CreateSubscriptionRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  NumberOfLicenses: ").Append(NumberOfLicenses).Append("\n");
            sb.Append("  AssignedLicenses: ").Append(AssignedLicenses).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  SubscriptionStatus: ").Append(SubscriptionStatus).Append("\n");
            sb.Append("  AutoAssign: ").Append(AutoAssign).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1CreateSubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.GracePeriod == input.GracePeriod ||
                    this.GracePeriod.Equals(input.GracePeriod)
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
                    this.LicenseType == input.LicenseType ||
                    this.LicenseType.Equals(input.LicenseType)
                ) && 
                (
                    this.SubscriptionStatus == input.SubscriptionStatus ||
                    this.SubscriptionStatus.Equals(input.SubscriptionStatus)
                ) && 
                (
                    this.AutoAssign == input.AutoAssign ||
                    this.AutoAssign.Equals(input.AutoAssign)
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
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GracePeriod.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.AssignedLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.LicenseType.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriptionStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoAssign.GetHashCode();
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
