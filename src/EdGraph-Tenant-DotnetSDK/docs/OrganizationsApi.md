# EdGraph.Tenant.Client.Api.OrganizationsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrganizationAsync**](OrganizationsApi.md#createorganizationasync) | **POST** /tenants/{tenantId}/organizations | Creates an Organization. |
| [**DeleteOrganizationAsync**](OrganizationsApi.md#deleteorganizationasync) | **DELETE** /tenants/{tenantId}/organizations/{organizationIdentifier} | Deletes an Organization. |
| [**GetEdFiAdminInstancesAsync**](OrganizationsApi.md#getedfiadmininstancesasync) | **GET** /tenants/{tenantId}/organizations/instances | Retrieves the tenant&#39;s Ed-Fi Admin instances. |
| [**GetOrganizationByIdAsync**](OrganizationsApi.md#getorganizationbyidasync) | **GET** /tenants/{tenantId}/organizations/{organizationIdentifier} | Retrieves an Organization by ID. |
| [**GetOrganizationsAsync**](OrganizationsApi.md#getorganizationsasync) | **GET** /tenants/{tenantId}/organizations | Retrieves a list of Organizations. |
| [**SyncOrganizationsAsync**](OrganizationsApi.md#syncorganizationsasync) | **POST** /tenants/{tenantId}/organizations/sync | Syncs an Ed-Fi Admin instance&#39;s organizations into the Tenant&#39;s organizations. |
| [**UpdateOrganizationAsync**](OrganizationsApi.md#updateorganizationasync) | **PUT** /tenants/{tenantId}/organizations/{organizationIdentifier} | Updates an Organization. |

<a id="createorganizationasync"></a>
# **CreateOrganizationAsync**
> TenantApiTenantV1OrganizationCreatedResponse CreateOrganizationAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateOrganizationRequest? tenantApiTenantV1CreateOrganizationRequest = null)

Creates an Organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateOrganizationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateOrganizationRequest = new TenantApiTenantV1CreateOrganizationRequest?(); // TenantApiTenantV1CreateOrganizationRequest? |  (optional) 

            try
            {
                // Creates an Organization.
                TenantApiTenantV1OrganizationCreatedResponse result = apiInstance.CreateOrganizationAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.CreateOrganizationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrganizationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an Organization.
    ApiResponse<TenantApiTenantV1OrganizationCreatedResponse> response = apiInstance.CreateOrganizationAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.CreateOrganizationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1CreateOrganizationRequest** | [**TenantApiTenantV1CreateOrganizationRequest?**](TenantApiTenantV1CreateOrganizationRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1OrganizationCreatedResponse**](TenantApiTenantV1OrganizationCreatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **201** | The resource was created. The location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteorganizationasync"></a>
# **DeleteOrganizationAsync**
> TenantApiTenantV1OrganizationDeletedResponse DeleteOrganizationAsync (string tenantId, string organizationIdentifier, string? apiVersion = null, string? xVersion = null)

Deletes an Organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class DeleteOrganizationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var organizationIdentifier = "organizationIdentifier_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Deletes an Organization.
                TenantApiTenantV1OrganizationDeletedResponse result = apiInstance.DeleteOrganizationAsync(tenantId, organizationIdentifier, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrganizationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Organization.
    ApiResponse<TenantApiTenantV1OrganizationDeletedResponse> response = apiInstance.DeleteOrganizationAsyncWithHttpInfo(tenantId, organizationIdentifier, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **organizationIdentifier** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1OrganizationDeletedResponse**](TenantApiTenantV1OrganizationDeletedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedfiadmininstancesasync"></a>
# **GetEdFiAdminInstancesAsync**
> TenantApiTenantV1GetEdFiAdminInstancesResponse GetEdFiAdminInstancesAsync (string tenantId, int? pageIndex = null, int? pageSize = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves the tenant's Ed-Fi Admin instances.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetEdFiAdminInstancesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var orderBy = "\"instanceName\"";  // string? |  (optional)  (default to "instanceName")
            var filter = "filter_example";  // string? |  (optional) 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves the tenant's Ed-Fi Admin instances.
                TenantApiTenantV1GetEdFiAdminInstancesResponse result = apiInstance.GetEdFiAdminInstancesAsync(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetEdFiAdminInstancesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdFiAdminInstancesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the tenant's Ed-Fi Admin instances.
    ApiResponse<TenantApiTenantV1GetEdFiAdminInstancesResponse> response = apiInstance.GetEdFiAdminInstancesAsyncWithHttpInfo(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetEdFiAdminInstancesAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **orderBy** | **string?** |  | [optional] [default to &quot;instanceName&quot;] |
| **filter** | **string?** |  | [optional]  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1GetEdFiAdminInstancesResponse**](TenantApiTenantV1GetEdFiAdminInstancesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationbyidasync"></a>
# **GetOrganizationByIdAsync**
> TenantApiTenantV1Organization GetOrganizationByIdAsync (string tenantId, string organizationIdentifier, string? apiVersion = null, string? xVersion = null)

Retrieves an Organization by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetOrganizationByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var organizationIdentifier = "organizationIdentifier_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves an Organization by ID.
                TenantApiTenantV1Organization result = apiInstance.GetOrganizationByIdAsync(tenantId, organizationIdentifier, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves an Organization by ID.
    ApiResponse<TenantApiTenantV1Organization> response = apiInstance.GetOrganizationByIdAsyncWithHttpInfo(tenantId, organizationIdentifier, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetOrganizationByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **organizationIdentifier** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1Organization**](TenantApiTenantV1Organization.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationsasync"></a>
# **GetOrganizationsAsync**
> TenantApiTenantV1GetOrganizationsPaginatedResponse GetOrganizationsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of Organizations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetOrganizationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of Organizations.
                TenantApiTenantV1GetOrganizationsPaginatedResponse result = apiInstance.GetOrganizationsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of Organizations.
    ApiResponse<TenantApiTenantV1GetOrganizationsPaginatedResponse> response = apiInstance.GetOrganizationsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1GetOrganizationsPaginatedResponse**](TenantApiTenantV1GetOrganizationsPaginatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="syncorganizationsasync"></a>
# **SyncOrganizationsAsync**
> void SyncOrganizationsAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1SyncOrganizationsRequest? tenantApiTenantV1SyncOrganizationsRequest = null)

Syncs an Ed-Fi Admin instance's organizations into the Tenant's organizations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class SyncOrganizationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1SyncOrganizationsRequest = new TenantApiTenantV1SyncOrganizationsRequest?(); // TenantApiTenantV1SyncOrganizationsRequest? |  (optional) 

            try
            {
                // Syncs an Ed-Fi Admin instance's organizations into the Tenant's organizations.
                apiInstance.SyncOrganizationsAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1SyncOrganizationsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.SyncOrganizationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SyncOrganizationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Syncs an Ed-Fi Admin instance's organizations into the Tenant's organizations.
    apiInstance.SyncOrganizationsAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1SyncOrganizationsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.SyncOrganizationsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1SyncOrganizationsRequest** | [**TenantApiTenantV1SyncOrganizationsRequest?**](TenantApiTenantV1SyncOrganizationsRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **201** | Created |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorganizationasync"></a>
# **UpdateOrganizationAsync**
> TenantApiTenantV1OrganizationUpdatedResponse UpdateOrganizationAsync (string tenantId, string organizationIdentifier, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateOrganizationRequest? tenantApiTenantV1UpdateOrganizationRequest = null)

Updates an Organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateOrganizationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var organizationIdentifier = "organizationIdentifier_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateOrganizationRequest = new TenantApiTenantV1UpdateOrganizationRequest?(); // TenantApiTenantV1UpdateOrganizationRequest? |  (optional) 

            try
            {
                // Updates an Organization.
                TenantApiTenantV1OrganizationUpdatedResponse result = apiInstance.UpdateOrganizationAsync(tenantId, organizationIdentifier, apiVersion, xVersion, tenantApiTenantV1UpdateOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrganizationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Organization.
    ApiResponse<TenantApiTenantV1OrganizationUpdatedResponse> response = apiInstance.UpdateOrganizationAsyncWithHttpInfo(tenantId, organizationIdentifier, apiVersion, xVersion, tenantApiTenantV1UpdateOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **organizationIdentifier** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1UpdateOrganizationRequest** | [**TenantApiTenantV1UpdateOrganizationRequest?**](TenantApiTenantV1UpdateOrganizationRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1OrganizationUpdatedResponse**](TenantApiTenantV1OrganizationUpdatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

