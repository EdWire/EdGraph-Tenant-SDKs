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
    /// Defines IdentityApi.ApiClient.V1.TokenExpiration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityApiApiClientV1TokenExpiration
    {
        /// <summary>
        /// Enum Sliding for value: Sliding
        /// </summary>
        [EnumMember(Value = "Sliding")]
        Sliding = 1,

        /// <summary>
        /// Enum Absolute for value: Absolute
        /// </summary>
        [EnumMember(Value = "Absolute")]
        Absolute = 2
    }

}
