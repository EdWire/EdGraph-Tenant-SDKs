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
    public interface ITenantSettingTypesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves all setting types
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel GetAllSettingTypes(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0);

        /// <summary>
        /// Retrieves all setting types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> GetAllSettingTypesWithHttpInfo(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITenantSettingTypesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves all setting types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        System.Threading.Tasks.Task<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> GetAllSettingTypesAsync(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves all setting types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel>> GetAllSettingTypesWithHttpInfoAsync(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITenantSettingTypesApi : ITenantSettingTypesApiSync, ITenantSettingTypesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TenantSettingTypesApi : ITenantSettingTypesApi
    {
        private EdGraph.Tenant.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantSettingTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantSettingTypesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantSettingTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantSettingTypesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TenantSettingTypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TenantSettingTypesApi(EdGraph.Tenant.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TenantSettingTypesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TenantSettingTypesApi(EdGraph.Tenant.Client.Client.ISynchronousClient client, EdGraph.Tenant.Client.Client.IAsynchronousClient asyncClient, EdGraph.Tenant.Client.Client.IReadableConfiguration configuration)
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
        /// Retrieves all setting types 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        public TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel GetAllSettingTypes(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0)
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> localVarResponse = GetAllSettingTypesWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all setting types 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        public EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> GetAllSettingTypesWithHttpInfo(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0)
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantSettingTypesApi->GetAllSettingTypes");
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
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }
            if (pageIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "pageIndex", pageIndex));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "orderBy", orderBy));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }

            localVarRequestOptions.Operation = "TenantSettingTypesApi.GetAllSettingTypes";
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
            var localVarResponse = this.Client.Get<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel>("/tenants/settings", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllSettingTypes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves all setting types 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel</returns>
        public async System.Threading.Tasks.Task<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> GetAllSettingTypesAsync(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel> localVarResponse = await GetAllSettingTypesWithHttpInfoAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all setting types 
        /// </summary>
        /// <exception cref="EdGraph.Tenant.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="pageIndex"> (optional, default to 0)</param>
        /// <param name="orderBy"> (optional, default to &quot;&quot;)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel)</returns>
        public async System.Threading.Tasks.Task<EdGraph.Tenant.Client.Client.ApiResponse<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel>> GetAllSettingTypesWithHttpInfoAsync(string tenantId, int? pageSize = default(int?), int? pageIndex = default(int?), string? orderBy = default(string?), string? filter = default(string?), string? apiVersion = default(string?), string? xVersion = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new EdGraph.Tenant.Client.Client.ApiException(400, "Missing required parameter 'tenantId' when calling TenantSettingTypesApi->GetAllSettingTypes");
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
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }
            if (pageIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "pageIndex", pageIndex));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "orderBy", orderBy));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Tenant.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Tenant.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }

            localVarRequestOptions.Operation = "TenantSettingTypesApi.GetAllSettingTypes";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<TenantApiTenantV1TenantSettingTypesListResponsePaginatedItemsViewModel>("/tenants/settings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllSettingTypes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
