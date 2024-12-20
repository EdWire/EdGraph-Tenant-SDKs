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
    ///  Class for testing PartnershipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PartnershipsApiTests : IDisposable
    {
        private PartnershipsApi instance;

        public PartnershipsApiTests()
        {
            instance = new PartnershipsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PartnershipsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PartnershipsApi
            //Assert.IsType<PartnershipsApi>(instance);
        }

        /// <summary>
        /// Test GetAllPartnerships
        /// </summary>
        [Fact]
        public void GetAllPartnershipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //int? pageIndex = null;
            //int? pageSize = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllPartnerships(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<TenantApiPartnershipV1PaginatedItemsResponse>(response);
        }

        /// <summary>
        /// Test GetPartnershipById
        /// </summary>
        [Fact]
        public void GetPartnershipByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //Guid partnershipId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetPartnershipById(tenantId, partnershipId, apiVersion, xVersion);
            //Assert.IsType<TenantApiPartnershipV1PartnershipByIdResponse>(response);
        }
    }
}
