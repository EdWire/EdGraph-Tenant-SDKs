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
    ///  Class for testing OnboardingStepsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnboardingStepsApiTests : IDisposable
    {
        private OnboardingStepsApi instance;

        public OnboardingStepsApiTests()
        {
            instance = new OnboardingStepsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnboardingStepsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OnboardingStepsApi
            //Assert.IsType<OnboardingStepsApi>(instance);
        }

        /// <summary>
        /// Test CreateOnboardingStepAsync
        /// </summary>
        [Fact]
        public void CreateOnboardingStepAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateOnboardingStepRequestDto? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateOnboardingStepRequestDto = null;
            //var response = instance.CreateOnboardingStepAsync(tenantId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsCreateOnboardingStepRequestDto);
            //Assert.IsType<TenantApiTenantV1TenantUpdatedResponse>(response);
        }

        /// <summary>
        /// Test UpdateOnboardingStepAsync
        /// </summary>
        [Fact]
        public void UpdateOnboardingStepAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int stepNumber = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateOnboardingStepRequestDto? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateOnboardingStepRequestDto = null;
            //var response = instance.UpdateOnboardingStepAsync(tenantId, stepNumber, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateOnboardingStepRequestDto);
            //Assert.IsType<TenantApiTenantV1TenantUpdatedResponse>(response);
        }
    }
}
