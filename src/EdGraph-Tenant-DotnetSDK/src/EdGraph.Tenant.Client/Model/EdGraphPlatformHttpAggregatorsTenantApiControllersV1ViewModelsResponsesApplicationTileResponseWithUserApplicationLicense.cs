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
    /// EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense
    /// </summary>
    [DataContract(Name = "EdGraph.Platform.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Responses.ApplicationTileResponseWithUserApplicationLicense")]
    public partial class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense : IEquatable<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense" /> class.
        /// </summary>
        /// <param name="applicationTenantId">The Tenant this application belongs to.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="applicationDescription">applicationDescription.</param>
        /// <param name="documentationUrl">documentationUrl.</param>
        /// <param name="applicationUri">applicationUri.</param>
        /// <param name="version">version.</param>
        /// <param name="tooltipText">tooltipText.</param>
        /// <param name="tags">tags.</param>
        /// <param name="groups">groups.</param>
        /// <param name="lightIconUrl">lightIconUrl.</param>
        /// <param name="darkIconUrl">darkIconUrl.</param>
        /// <param name="lightBackgroundTileUrl">lightBackgroundTileUrl.</param>
        /// <param name="darkBackgroundTileUrl">darkBackgroundTileUrl.</param>
        /// <param name="lightOverlayTileUrl">lightOverlayTileUrl.</param>
        /// <param name="darkOverlayTileUrl">darkOverlayTileUrl.</param>
        /// <param name="showInAppLauncher">showInAppLauncher.</param>
        /// <param name="showInQuickLauncher">showInQuickLauncher.</param>
        /// <param name="openInNewWindow">openInNewWindow.</param>
        /// <param name="isTenantSubscribed">isTenantSubscribed.</param>
        /// <param name="subscriptionTenantId">The Tenant Id the subscription belongs to.</param>
        /// <param name="tenantSubscriptionId">The Tenant subscription Id.</param>
        /// <param name="tenantSubscriptionStartDateTime">The Tenant subscription start date.</param>
        /// <param name="tenantSubscriptionEndDateTime">The Tenant subscription end date.</param>
        /// <param name="tenantSubscriptionActualEndDateTime">The Tenant subscription end date.</param>
        /// <param name="isUserLicensed">isUserLicensed.</param>
        public EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense(string applicationTenantId = default(string), string applicationId = default(string), string applicationName = default(string), string applicationDescription = default(string), string documentationUrl = default(string), string applicationUri = default(string), string version = default(string), string tooltipText = default(string), string tags = default(string), string groups = default(string), string lightIconUrl = default(string), string darkIconUrl = default(string), string lightBackgroundTileUrl = default(string), string darkBackgroundTileUrl = default(string), string lightOverlayTileUrl = default(string), string darkOverlayTileUrl = default(string), bool showInAppLauncher = default(bool), bool showInQuickLauncher = default(bool), bool openInNewWindow = default(bool), bool isTenantSubscribed = default(bool), string subscriptionTenantId = default(string), string tenantSubscriptionId = default(string), string tenantSubscriptionStartDateTime = default(string), string tenantSubscriptionEndDateTime = default(string), string tenantSubscriptionActualEndDateTime = default(string), bool isUserLicensed = default(bool))
        {
            this.ApplicationTenantId = applicationTenantId;
            this.ApplicationId = applicationId;
            this.ApplicationName = applicationName;
            this.ApplicationDescription = applicationDescription;
            this.DocumentationUrl = documentationUrl;
            this.ApplicationUri = applicationUri;
            this._Version = version;
            this.TooltipText = tooltipText;
            this.Tags = tags;
            this.Groups = groups;
            this.LightIconUrl = lightIconUrl;
            this.DarkIconUrl = darkIconUrl;
            this.LightBackgroundTileUrl = lightBackgroundTileUrl;
            this.DarkBackgroundTileUrl = darkBackgroundTileUrl;
            this.LightOverlayTileUrl = lightOverlayTileUrl;
            this.DarkOverlayTileUrl = darkOverlayTileUrl;
            this.ShowInAppLauncher = showInAppLauncher;
            this.ShowInQuickLauncher = showInQuickLauncher;
            this.OpenInNewWindow = openInNewWindow;
            this.IsTenantSubscribed = isTenantSubscribed;
            this.SubscriptionTenantId = subscriptionTenantId;
            this.TenantSubscriptionId = tenantSubscriptionId;
            this.TenantSubscriptionStartDateTime = tenantSubscriptionStartDateTime;
            this.TenantSubscriptionEndDateTime = tenantSubscriptionEndDateTime;
            this.TenantSubscriptionActualEndDateTime = tenantSubscriptionActualEndDateTime;
            this.IsUserLicensed = isUserLicensed;
        }

        /// <summary>
        /// The Tenant this application belongs to
        /// </summary>
        /// <value>The Tenant this application belongs to</value>
        [DataMember(Name = "applicationTenantId", EmitDefaultValue = true)]
        public string ApplicationTenantId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name = "applicationName", EmitDefaultValue = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationDescription
        /// </summary>
        [DataMember(Name = "applicationDescription", EmitDefaultValue = true)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// Gets or Sets DocumentationUrl
        /// </summary>
        [DataMember(Name = "documentationUrl", EmitDefaultValue = true)]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationUri
        /// </summary>
        [DataMember(Name = "applicationUri", EmitDefaultValue = true)]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets TooltipText
        /// </summary>
        [DataMember(Name = "tooltipText", EmitDefaultValue = true)]
        public string TooltipText { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public string Groups { get; set; }

        /// <summary>
        /// Gets or Sets LightIconUrl
        /// </summary>
        [DataMember(Name = "lightIconUrl", EmitDefaultValue = true)]
        public string LightIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkIconUrl
        /// </summary>
        [DataMember(Name = "darkIconUrl", EmitDefaultValue = true)]
        public string DarkIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets LightBackgroundTileUrl
        /// </summary>
        [DataMember(Name = "lightBackgroundTileUrl", EmitDefaultValue = true)]
        public string LightBackgroundTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkBackgroundTileUrl
        /// </summary>
        [DataMember(Name = "darkBackgroundTileUrl", EmitDefaultValue = true)]
        public string DarkBackgroundTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets LightOverlayTileUrl
        /// </summary>
        [DataMember(Name = "lightOverlayTileUrl", EmitDefaultValue = true)]
        public string LightOverlayTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkOverlayTileUrl
        /// </summary>
        [DataMember(Name = "darkOverlayTileUrl", EmitDefaultValue = true)]
        public string DarkOverlayTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets ShowInAppLauncher
        /// </summary>
        [DataMember(Name = "showInAppLauncher", EmitDefaultValue = true)]
        public bool ShowInAppLauncher { get; set; }

        /// <summary>
        /// Gets or Sets ShowInQuickLauncher
        /// </summary>
        [DataMember(Name = "showInQuickLauncher", EmitDefaultValue = true)]
        public bool ShowInQuickLauncher { get; set; }

        /// <summary>
        /// Gets or Sets OpenInNewWindow
        /// </summary>
        [DataMember(Name = "openInNewWindow", EmitDefaultValue = true)]
        public bool OpenInNewWindow { get; set; }

        /// <summary>
        /// Gets or Sets IsTenantSubscribed
        /// </summary>
        [DataMember(Name = "isTenantSubscribed", EmitDefaultValue = true)]
        public bool IsTenantSubscribed { get; set; }

        /// <summary>
        /// The Tenant Id the subscription belongs to
        /// </summary>
        /// <value>The Tenant Id the subscription belongs to</value>
        [DataMember(Name = "subscriptionTenantId", EmitDefaultValue = true)]
        public string SubscriptionTenantId { get; set; }

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
        /// Gets or Sets IsUserLicensed
        /// </summary>
        [DataMember(Name = "isUserLicensed", EmitDefaultValue = true)]
        public bool IsUserLicensed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense {\n");
            sb.Append("  ApplicationTenantId: ").Append(ApplicationTenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  TooltipText: ").Append(TooltipText).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  LightIconUrl: ").Append(LightIconUrl).Append("\n");
            sb.Append("  DarkIconUrl: ").Append(DarkIconUrl).Append("\n");
            sb.Append("  LightBackgroundTileUrl: ").Append(LightBackgroundTileUrl).Append("\n");
            sb.Append("  DarkBackgroundTileUrl: ").Append(DarkBackgroundTileUrl).Append("\n");
            sb.Append("  LightOverlayTileUrl: ").Append(LightOverlayTileUrl).Append("\n");
            sb.Append("  DarkOverlayTileUrl: ").Append(DarkOverlayTileUrl).Append("\n");
            sb.Append("  ShowInAppLauncher: ").Append(ShowInAppLauncher).Append("\n");
            sb.Append("  ShowInQuickLauncher: ").Append(ShowInQuickLauncher).Append("\n");
            sb.Append("  OpenInNewWindow: ").Append(OpenInNewWindow).Append("\n");
            sb.Append("  IsTenantSubscribed: ").Append(IsTenantSubscribed).Append("\n");
            sb.Append("  SubscriptionTenantId: ").Append(SubscriptionTenantId).Append("\n");
            sb.Append("  TenantSubscriptionId: ").Append(TenantSubscriptionId).Append("\n");
            sb.Append("  TenantSubscriptionStartDateTime: ").Append(TenantSubscriptionStartDateTime).Append("\n");
            sb.Append("  TenantSubscriptionEndDateTime: ").Append(TenantSubscriptionEndDateTime).Append("\n");
            sb.Append("  TenantSubscriptionActualEndDateTime: ").Append(TenantSubscriptionActualEndDateTime).Append("\n");
            sb.Append("  IsUserLicensed: ").Append(IsUserLicensed).Append("\n");
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
            return this.Equals(input as EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense);
        }

        /// <summary>
        /// Returns true if EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTileResponseWithUserApplicationLicense input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.ApplicationDescription == input.ApplicationDescription ||
                    (this.ApplicationDescription != null &&
                    this.ApplicationDescription.Equals(input.ApplicationDescription))
                ) && 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && 
                (
                    this.ApplicationUri == input.ApplicationUri ||
                    (this.ApplicationUri != null &&
                    this.ApplicationUri.Equals(input.ApplicationUri))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.TooltipText == input.TooltipText ||
                    (this.TooltipText != null &&
                    this.TooltipText.Equals(input.TooltipText))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.LightIconUrl == input.LightIconUrl ||
                    (this.LightIconUrl != null &&
                    this.LightIconUrl.Equals(input.LightIconUrl))
                ) && 
                (
                    this.DarkIconUrl == input.DarkIconUrl ||
                    (this.DarkIconUrl != null &&
                    this.DarkIconUrl.Equals(input.DarkIconUrl))
                ) && 
                (
                    this.LightBackgroundTileUrl == input.LightBackgroundTileUrl ||
                    (this.LightBackgroundTileUrl != null &&
                    this.LightBackgroundTileUrl.Equals(input.LightBackgroundTileUrl))
                ) && 
                (
                    this.DarkBackgroundTileUrl == input.DarkBackgroundTileUrl ||
                    (this.DarkBackgroundTileUrl != null &&
                    this.DarkBackgroundTileUrl.Equals(input.DarkBackgroundTileUrl))
                ) && 
                (
                    this.LightOverlayTileUrl == input.LightOverlayTileUrl ||
                    (this.LightOverlayTileUrl != null &&
                    this.LightOverlayTileUrl.Equals(input.LightOverlayTileUrl))
                ) && 
                (
                    this.DarkOverlayTileUrl == input.DarkOverlayTileUrl ||
                    (this.DarkOverlayTileUrl != null &&
                    this.DarkOverlayTileUrl.Equals(input.DarkOverlayTileUrl))
                ) && 
                (
                    this.ShowInAppLauncher == input.ShowInAppLauncher ||
                    this.ShowInAppLauncher.Equals(input.ShowInAppLauncher)
                ) && 
                (
                    this.ShowInQuickLauncher == input.ShowInQuickLauncher ||
                    this.ShowInQuickLauncher.Equals(input.ShowInQuickLauncher)
                ) && 
                (
                    this.OpenInNewWindow == input.OpenInNewWindow ||
                    this.OpenInNewWindow.Equals(input.OpenInNewWindow)
                ) && 
                (
                    this.IsTenantSubscribed == input.IsTenantSubscribed ||
                    this.IsTenantSubscribed.Equals(input.IsTenantSubscribed)
                ) && 
                (
                    this.SubscriptionTenantId == input.SubscriptionTenantId ||
                    (this.SubscriptionTenantId != null &&
                    this.SubscriptionTenantId.Equals(input.SubscriptionTenantId))
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
                    this.IsUserLicensed == input.IsUserLicensed ||
                    this.IsUserLicensed.Equals(input.IsUserLicensed)
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
                if (this.ApplicationDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationDescription.GetHashCode();
                }
                if (this.DocumentationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentationUrl.GetHashCode();
                }
                if (this.ApplicationUri != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationUri.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.TooltipText != null)
                {
                    hashCode = (hashCode * 59) + this.TooltipText.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.LightIconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightIconUrl.GetHashCode();
                }
                if (this.DarkIconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkIconUrl.GetHashCode();
                }
                if (this.LightBackgroundTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightBackgroundTileUrl.GetHashCode();
                }
                if (this.DarkBackgroundTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkBackgroundTileUrl.GetHashCode();
                }
                if (this.LightOverlayTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightOverlayTileUrl.GetHashCode();
                }
                if (this.DarkOverlayTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkOverlayTileUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowInAppLauncher.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowInQuickLauncher.GetHashCode();
                hashCode = (hashCode * 59) + this.OpenInNewWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.IsTenantSubscribed.GetHashCode();
                if (this.SubscriptionTenantId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionTenantId.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.IsUserLicensed.GetHashCode();
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
