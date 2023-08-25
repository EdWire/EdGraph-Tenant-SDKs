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
    /// EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Requests.CreateLocalUserRequest")]
    public partial class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest : IEquatable<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="email">email.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="role">role.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="lockoutEnabled">lockoutEnabled.</param>
        /// <param name="password">password.</param>
        /// <param name="autoGeneratedPassword">autoGeneratedPassword.</param>
        /// <param name="twoFactorEnabled">twoFactorEnabled.</param>
        /// <param name="sendEmail">sendEmail.</param>
        /// <param name="assignLicenseRequests">assignLicenseRequests.</param>
        public EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest(string tenantId = default(string), string userName = default(string), string email = default(string), string firstName = default(string), string lastName = default(string), string role = default(string), string phoneNumber = default(string), bool lockoutEnabled = default(bool), string password = default(string), bool autoGeneratedPassword = default(bool), bool twoFactorEnabled = default(bool), bool sendEmail = default(bool), List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesAssignLicenseRequest> assignLicenseRequests = default(List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesAssignLicenseRequest>))
        {
            this.TenantId = tenantId;
            this.UserName = userName;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.PhoneNumber = phoneNumber;
            this.LockoutEnabled = lockoutEnabled;
            this.Password = password;
            this.AutoGeneratedPassword = autoGeneratedPassword;
            this.TwoFactorEnabled = twoFactorEnabled;
            this.SendEmail = sendEmail;
            this.AssignLicenseRequests = assignLicenseRequests;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets LockoutEnabled
        /// </summary>
        [DataMember(Name = "lockoutEnabled", EmitDefaultValue = true)]
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets AutoGeneratedPassword
        /// </summary>
        [DataMember(Name = "autoGeneratedPassword", EmitDefaultValue = true)]
        public bool AutoGeneratedPassword { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorEnabled
        /// </summary>
        [DataMember(Name = "twoFactorEnabled", EmitDefaultValue = true)]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SendEmail
        /// </summary>
        [DataMember(Name = "sendEmail", EmitDefaultValue = true)]
        public bool SendEmail { get; set; }

        /// <summary>
        /// Gets or Sets AssignLicenseRequests
        /// </summary>
        [DataMember(Name = "assignLicenseRequests", EmitDefaultValue = true)]
        public List<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsLicensesAssignLicenseRequest> AssignLicenseRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  LockoutEnabled: ").Append(LockoutEnabled).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AutoGeneratedPassword: ").Append(AutoGeneratedPassword).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
            sb.Append("  SendEmail: ").Append(SendEmail).Append("\n");
            sb.Append("  AssignLicenseRequests: ").Append(AssignLicenseRequests).Append("\n");
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
            return this.Equals(input as EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateLocalUserRequest input)
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
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.LockoutEnabled == input.LockoutEnabled ||
                    this.LockoutEnabled.Equals(input.LockoutEnabled)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AutoGeneratedPassword == input.AutoGeneratedPassword ||
                    this.AutoGeneratedPassword.Equals(input.AutoGeneratedPassword)
                ) && 
                (
                    this.TwoFactorEnabled == input.TwoFactorEnabled ||
                    this.TwoFactorEnabled.Equals(input.TwoFactorEnabled)
                ) && 
                (
                    this.SendEmail == input.SendEmail ||
                    this.SendEmail.Equals(input.SendEmail)
                ) && 
                (
                    this.AssignLicenseRequests == input.AssignLicenseRequests ||
                    this.AssignLicenseRequests != null &&
                    input.AssignLicenseRequests != null &&
                    this.AssignLicenseRequests.SequenceEqual(input.AssignLicenseRequests)
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
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LockoutEnabled.GetHashCode();
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoGeneratedPassword.GetHashCode();
                hashCode = (hashCode * 59) + this.TwoFactorEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.SendEmail.GetHashCode();
                if (this.AssignLicenseRequests != null)
                {
                    hashCode = (hashCode * 59) + this.AssignLicenseRequests.GetHashCode();
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
