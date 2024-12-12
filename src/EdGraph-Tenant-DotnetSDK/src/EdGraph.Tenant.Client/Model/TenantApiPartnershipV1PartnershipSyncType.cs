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
    /// Defines TenantApi.Partnership.V1.PartnershipSyncType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TenantApiPartnershipV1PartnershipSyncType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Inbound for value: Inbound
        /// </summary>
        [EnumMember(Value = "Inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for value: Outbound
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound
    }

}
