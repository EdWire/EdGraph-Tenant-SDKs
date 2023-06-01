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
    /// Defines ApplicationApi.Application.V2.ApplicationStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplicationApiApplicationV2ApplicationStatus
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Draft for value: Draft
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft = 2,

        /// <summary>
        /// Enum Published for value: Published
        /// </summary>
        [EnumMember(Value = "Published")]
        Published = 3

    }

}
