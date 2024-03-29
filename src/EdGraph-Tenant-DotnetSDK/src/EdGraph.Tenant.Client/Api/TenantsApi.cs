/*
 * Tenant Api
 *
 * Tenant Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Client.Auth;
using EdGraph.Tenant.Client.Model;

namespace EdGraph.Tenant.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITenantsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the profile of a specific tenant
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantProfileResponse</returns>
        TenantApiTenantV1TenantProfileResponse GetTenantByIdAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0);

        /// <summary>
        /// Retrieves the profile of a specific tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantProfileResponse</returns>
        ApiResponse<TenantApiTenantV1TenantProfileResponse> GetTenantByIdAsyncWithHttpInfo(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0);
        /// <summary>
        /// Updates a tenant&#39;s profile
        /// </summary>
        /// <remarks>
        /// Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantUpdatedResponse</returns>
        TenantApiTenantV1TenantUpdatedResponse UpdateTenantAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0);

        /// <summary>
        /// Updates a tenant&#39;s profile
        /// </summary>
        /// <remarks>
        /// Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantUpdatedResponse</returns>
        ApiResponse<TenantApiTenantV1TenantUpdatedResponse> UpdateTenantAsyncWithHttpInfo(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITenantsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the profile of a specific tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantProfileResponse</returns>
        System.Threading.Tasks.Task<TenantApiTenantV1TenantProfileResponse> GetTenantByIdAsyncAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the profile of a specific tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantProfileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantApiTenantV1TenantProfileResponse>> GetTenantByIdAsyncWithHttpInfoAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates a tenant&#39;s profile
        /// </summary>
        /// <remarks>
        /// Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantUpdatedResponse</returns>
        System.Threading.Tasks.Task<TenantApiTenantV1TenantUpdatedResponse> UpdateTenantAsyncAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Updates a tenant&#39;s profile
        /// </summary>
        /// <remarks>
        /// Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantUpdatedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantApiTenantV1TenantUpdatedResponse>> UpdateTenantAsyncWithHttpInfoAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITenantsApi : ITenantsApiSync, ITenantsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TenantsApi : ITenantsApi
    {
        private EdGraph.Tenant.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantsApi(string basePath)
        {
            this.Configuration = EdGraph.Tenant.Client.Client.Configuration.MergeConfigurations(
                EdGraph.Tenant.Client.Client.GlobalConfiguration.Instance,
                new EdGraph.Tenant.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new EdGraph.Tenant.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdGraph.Tenant.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = EdGraph.Tenant.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TenantsApi(EdGraph.Tenant.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = EdGraph.Tenant.Client.Client.Configuration.MergeConfigurations(
                EdGraph.Tenant.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new EdGraph.Tenant.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdGraph.Tenant.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = EdGraph.Tenant.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TenantsApi(EdGraph.Tenant.Client.Client.ISynchronousClient client, EdGraph.Tenant.Client.Client.IAsynchronousClient asyncClient, EdGraph.Tenant.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = EdGraph.Tenant.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public EdGraph.Tenant.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public EdGraph.Tenant.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public EdGraph.Tenant.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EdGraph.Tenant.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieves the profile of a specific tenant 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantProfileResponse</returns>
        public TenantApiTenantV1TenantProfileResponse GetTenantByIdAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0)
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantProfileResponse> localVarResponse = GetTenantByIdAsyncWithHttpInfo(tenantId, apiVersion, xVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the profile of a specific tenant 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantProfileResponse</returns>
        public EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantProfileResponse> GetTenantByIdAsyncWithHttpInfo(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0)
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantsApi->GetTenantByIdAsync");
            }

            EdGraph.Tenant.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Tenant.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }

            localVarRequestOptions.Operation = "TenantsApi.GetTenantByIdAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TenantApiTenantV1TenantProfileResponse>("/tenants/{tenantId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantByIdAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the profile of a specific tenant 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantProfileResponse</returns>
        public async System.Threading.Tasks.Task<TenantApiTenantV1TenantProfileResponse> GetTenantByIdAsyncAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantProfileResponse> localVarResponse = await GetTenantByIdAsyncWithHttpInfoAsync(tenantId, apiVersion, xVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the profile of a specific tenant 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantProfileResponse)</returns>
        public async System.Threading.Tasks.Task<EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantProfileResponse>> GetTenantByIdAsyncWithHttpInfoAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantsApi->GetTenantByIdAsync");
            }


            EdGraph.Tenant.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Tenant.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }

            localVarRequestOptions.Operation = "TenantsApi.GetTenantByIdAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TenantApiTenantV1TenantProfileResponse>("/tenants/{tenantId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantByIdAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Updates a tenant&#39;s profile Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantUpdatedResponse</returns>
        public TenantApiTenantV1TenantUpdatedResponse UpdateTenantAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0)
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantUpdatedResponse> localVarResponse = UpdateTenantAsyncWithHttpInfo(tenantId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a tenant&#39;s profile Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantUpdatedResponse</returns>
        public EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantUpdatedResponse> UpdateTenantAsyncWithHttpInfo(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0)
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantsApi->UpdateTenantAsync");
            }

            EdGraph.Tenant.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Tenant.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest;

            localVarRequestOptions.Operation = "TenantsApi.UpdateTenantAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<TenantApiTenantV1TenantUpdatedResponse>("/tenants/{tenantId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateTenantAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Updates a tenant&#39;s profile Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantUpdatedResponse</returns>
        public async System.Threading.Tasks.Task<TenantApiTenantV1TenantUpdatedResponse> UpdateTenantAsyncAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantUpdatedResponse> localVarResponse = await UpdateTenantAsyncWithHttpInfoAsync(tenantId, apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a tenant&#39;s profile Note: Only the tenant&#39;s Identity Providers can be updated at this time
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantUpdatedResponse)</returns>
        public async System.Threading.Tasks.Task<EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantUpdatedResponse>> UpdateTenantAsyncWithHttpInfoAsync(string tenantId, string? apiVersion = default(string?), string? xVersion = default(string?), EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest = default(EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantsApi->UpdateTenantAsync");
            }


            EdGraph.Tenant.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Tenant.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Tenant.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsTenantsUpdateTenantRequest;

            localVarRequestOptions.Operation = "TenantsApi.UpdateTenantAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<TenantApiTenantV1TenantUpdatedResponse>("/tenants/{tenantId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateTenantAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
