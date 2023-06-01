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
    ///  Class for testing IdentityAPIClientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IdentityAPIClientsApiTests : IDisposable
    {
        private IdentityAPIClientsApi instance;

        public IdentityAPIClientsApiTests()
        {
            instance = new IdentityAPIClientsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityAPIClientsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IdentityAPIClientsApi
            //Assert.IsType<IdentityAPIClientsApi>(instance);
        }

        /// <summary>
        /// Test CreateTenantApiClient
        /// </summary>
        [Fact]
        public void CreateTenantApiClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //IdentityApiApiClientV1CreateApiClientRequest? identityApiApiClientV1CreateApiClientRequest = null;
            //instance.CreateTenantApiClient(tenantId, apiVersion, xVersion, identityApiApiClientV1CreateApiClientRequest);
        }

        /// <summary>
        /// Test DeleteTenantApiClient
        /// </summary>
        [Fact]
        public void DeleteTenantApiClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string clientId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteTenantApiClient(tenantId, clientId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetAllTenantApiClients
        /// </summary>
        [Fact]
        public void GetAllTenantApiClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllTenantApiClients(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetTenantApiClientProfileById
        /// </summary>
        [Fact]
        public void GetTenantApiClientProfileByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string clientId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetTenantApiClientProfileById(tenantId, clientId, apiVersion, xVersion);
            //Assert.IsType<IdentityApiApiClientV1ApiClientProfileResponse>(response);
        }

        /// <summary>
        /// Test RegenerateTenantApiClientSecret
        /// </summary>
        [Fact]
        public void RegenerateTenantApiClientSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string clientId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //IdentityApiApiClientV1RegenerateApiClientSecretRequest? identityApiApiClientV1RegenerateApiClientSecretRequest = null;
            //instance.RegenerateTenantApiClientSecret(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1RegenerateApiClientSecretRequest);
        }

        /// <summary>
        /// Test UpdateTenantApiClient
        /// </summary>
        [Fact]
        public void UpdateTenantApiClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string clientId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //IdentityApiApiClientV1UpdateApiClientRequest? identityApiApiClientV1UpdateApiClientRequest = null;
            //instance.UpdateTenantApiClient(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1UpdateApiClientRequest);
        }
    }
}
