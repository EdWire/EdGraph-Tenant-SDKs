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
    ///  Class for testing OrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationsApiTests : IDisposable
    {
        private OrganizationsApi instance;

        public OrganizationsApiTests()
        {
            instance = new OrganizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationsApi
            //Assert.IsType<OrganizationsApi>(instance);
        }

        /// <summary>
        /// Test CreateOrganizationAsync
        /// </summary>
        [Fact]
        public void CreateOrganizationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //TenantApiTenantV1CreateOrganizationRequest? tenantApiTenantV1CreateOrganizationRequest = null;
            //var response = instance.CreateOrganizationAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateOrganizationRequest);
            //Assert.IsType<TenantApiTenantV1OrganizationCreatedResponse>(response);
        }

        /// <summary>
        /// Test DeleteOrganizationAsync
        /// </summary>
        [Fact]
        public void DeleteOrganizationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string organizationIdentifier = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.DeleteOrganizationAsync(tenantId, organizationIdentifier, apiVersion, xVersion);
            //Assert.IsType<TenantApiTenantV1OrganizationDeletedResponse>(response);
        }

        /// <summary>
        /// Test GetEdFiAdminInstancesAsync
        /// </summary>
        [Fact]
        public void GetEdFiAdminInstancesAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int? pageIndex = null;
            //int? pageSize = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetEdFiAdminInstancesAsync(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<TenantApiTenantV1GetEdFiAdminInstancesResponse>(response);
        }

        /// <summary>
        /// Test GetOrganizationByIdAsync
        /// </summary>
        [Fact]
        public void GetOrganizationByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string organizationIdentifier = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetOrganizationByIdAsync(tenantId, organizationIdentifier, apiVersion, xVersion);
            //Assert.IsType<TenantApiTenantV1Organization>(response);
        }

        /// <summary>
        /// Test GetOrganizationsAsync
        /// </summary>
        [Fact]
        public void GetOrganizationsAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetOrganizationsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<TenantApiTenantV1GetOrganizationsPaginatedResponse>(response);
        }

        /// <summary>
        /// Test SyncOrganizationsAsync
        /// </summary>
        [Fact]
        public void SyncOrganizationsAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //TenantApiTenantV1SyncOrganizationsRequest? tenantApiTenantV1SyncOrganizationsRequest = null;
            //instance.SyncOrganizationsAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1SyncOrganizationsRequest);
        }

        /// <summary>
        /// Test UpdateOrganizationAsync
        /// </summary>
        [Fact]
        public void UpdateOrganizationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string organizationIdentifier = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //TenantApiTenantV1UpdateOrganizationRequest? tenantApiTenantV1UpdateOrganizationRequest = null;
            //var response = instance.UpdateOrganizationAsync(tenantId, organizationIdentifier, apiVersion, xVersion, tenantApiTenantV1UpdateOrganizationRequest);
            //Assert.IsType<TenantApiTenantV1OrganizationUpdatedResponse>(response);
        }
    }
}
