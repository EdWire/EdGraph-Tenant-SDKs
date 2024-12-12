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
    /// Defines EdGraph.HttpAggregators.Tenant.Api.Controllers.v1.ViewModels.Requests.Tenants.TenantType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsTenantType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum DataStandardGoverningBody for value: DataStandardGoverningBody
        /// </summary>
        [EnumMember(Value = "DataStandardGoverningBody")]
        DataStandardGoverningBody,

        /// <summary>
        /// Enum EducationalServiceAgency for value: EducationalServiceAgency
        /// </summary>
        [EnumMember(Value = "EducationalServiceAgency")]
        EducationalServiceAgency,

        /// <summary>
        /// Enum ImplementationPartner for value: ImplementationPartner
        /// </summary>
        [EnumMember(Value = "ImplementationPartner")]
        ImplementationPartner,

        /// <summary>
        /// Enum IndependentSoftwareVendor for value: IndependentSoftwareVendor
        /// </summary>
        [EnumMember(Value = "IndependentSoftwareVendor")]
        IndependentSoftwareVendor,

        /// <summary>
        /// Enum Internal for value: Internal
        /// </summary>
        [EnumMember(Value = "Internal")]
        Internal,

        /// <summary>
        /// Enum LocalEducationAgency for value: LocalEducationAgency
        /// </summary>
        [EnumMember(Value = "LocalEducationAgency")]
        LocalEducationAgency,

        /// <summary>
        /// Enum ManagedServiceProvider for value: ManagedServiceProvider
        /// </summary>
        [EnumMember(Value = "ManagedServiceProvider")]
        ManagedServiceProvider,

        /// <summary>
        /// Enum StateEducationAgency for value: StateEducationAgency
        /// </summary>
        [EnumMember(Value = "StateEducationAgency")]
        StateEducationAgency
    }

}
