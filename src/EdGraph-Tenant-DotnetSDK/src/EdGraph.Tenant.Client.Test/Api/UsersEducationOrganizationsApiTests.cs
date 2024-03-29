/*
 * Tenant Api
 *
 * Tenant Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Api;
// uncomment below to import models
//using EdGraph.Tenant.Client.Model;

namespace EdGraph.Tenant.Client.Test.Api
{
    /// <summary>
    ///  Class for testing UsersEducationOrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersEducationOrganizationsApiTests : IDisposable
    {
        private UsersEducationOrganizationsApi instance;

        public UsersEducationOrganizationsApiTests()
        {
            instance = new UsersEducationOrganizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersEducationOrganizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersEducationOrganizationsApi
            //Assert.IsType<UsersEducationOrganizationsApi>(instance);
        }

        /// <summary>
        /// Test AddUserEducationOrganization
        /// </summary>
        [Fact]
        public void AddUserEducationOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //Guid userId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest = null;
            //var response = instance.AddUserEducationOrganization(tenantId, userId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsAddEducationOrganizationRequest);
            //Assert.IsType<IdentityApiUserV1EducationOrganizationAddedResponse>(response);
        }

        /// <summary>
        /// Test GetUserEducationOrganizations
        /// </summary>
        [Fact]
        public void GetUserEducationOrganizationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //Guid userId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetUserEducationOrganizations(tenantId, userId, apiVersion, xVersion);
            //Assert.IsType<IdentityApiUserV1EducationOrganizationPaginatedItemsResponse>(response);
        }

        /// <summary>
        /// Test RemoveUserEducationOrganization
        /// </summary>
        [Fact]
        public void RemoveUserEducationOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //Guid userId = null;
            //int educationOrganizationId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.RemoveUserEducationOrganization(tenantId, userId, educationOrganizationId, apiVersion, xVersion);
            //Assert.IsType<IdentityApiUserV1EducationOrganizationRemovedResponse>(response);
        }

        /// <summary>
        /// Test UpdateUserEducationOrganization
        /// </summary>
        [Fact]
        public void UpdateUserEducationOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //Guid userId = null;
            //int educationOrganizationId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsUpdateEducationOrganizationRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsUpdateEducationOrganizationRequest = null;
            //var response = instance.UpdateUserEducationOrganization(tenantId, userId, educationOrganizationId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsEducationOrganizationsUpdateEducationOrganizationRequest);
            //Assert.IsType<IdentityApiUserV1EducationOrganizationUpdatedResponse>(response);
        }
    }
}
