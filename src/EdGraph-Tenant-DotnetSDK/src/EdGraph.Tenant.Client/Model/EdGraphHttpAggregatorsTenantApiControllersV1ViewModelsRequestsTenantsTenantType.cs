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
        Unknown = 1,

        /// <summary>
        /// Enum Internal for value: Internal
        /// </summary>
        [EnumMember(Value = "Internal")]
        Internal = 2,

        /// <summary>
        /// Enum State for value: State
        /// </summary>
        [EnumMember(Value = "State")]
        State = 3,

        /// <summary>
        /// Enum Collaborative for value: Collaborative
        /// </summary>
        [EnumMember(Value = "Collaborative")]
        Collaborative = 4,

        /// <summary>
        /// Enum District for value: District
        /// </summary>
        [EnumMember(Value = "District")]
        District = 5,

        /// <summary>
        /// Enum Partner for value: Partner
        /// </summary>
        [EnumMember(Value = "Partner")]
        Partner = 6,

        /// <summary>
        /// Enum Teacher for value: Teacher
        /// </summary>
        [EnumMember(Value = "Teacher")]
        Teacher = 7,

        /// <summary>
        /// Enum Student for value: Student
        /// </summary>
        [EnumMember(Value = "Student")]
        Student = 8

    }

}
