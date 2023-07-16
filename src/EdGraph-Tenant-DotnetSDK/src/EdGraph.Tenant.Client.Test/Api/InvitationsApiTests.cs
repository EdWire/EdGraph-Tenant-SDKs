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
    ///  Class for testing InvitationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvitationsApiTests : IDisposable
    {
        private InvitationsApi instance;

        public InvitationsApiTests()
        {
            instance = new InvitationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvitationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvitationsApi
            //Assert.IsType<InvitationsApi>(instance);
        }

        /// <summary>
        /// Test DeleteTenantInvitationAsync
        /// </summary>
        [Fact]
        public void DeleteTenantInvitationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string invitationId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteTenantInvitationAsync(tenantId, invitationId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetAllTenantInvitationsAsync
        /// </summary>
        [Fact]
        public void GetAllTenantInvitationsAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllTenantInvitationsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetTenantInvitationByIdAsync
        /// </summary>
        [Fact]
        public void GetTenantInvitationByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string invitationId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetTenantInvitationByIdAsync(tenantId, invitationId, apiVersion, xVersion);
            //Assert.IsType<IdentityApiInvitationV1InvitationResponse>(response);
        }

        /// <summary>
        /// Test SendTenantInvitationAsync
        /// </summary>
        [Fact]
        public void SendTenantInvitationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsSendInvitationRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsSendInvitationRequest = null;
            //var response = instance.SendTenantInvitationAsync(tenantId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsSendInvitationRequest);
            //Assert.IsType<IdentityApiInvitationV1InvitationSentResponse>(response);
        }
    }
}
