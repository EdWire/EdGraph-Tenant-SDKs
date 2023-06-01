# EdGraph.Tenant.Client.Api.ApplicationsApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTenantApplicationProfileByIdAsync**](ApplicationsApi.md#gettenantapplicationprofilebyidasync) | **GET** /tenants/{tenantId}/applications/{applicationId} | Retrieves a specific application associated to a tenant using its primary key |
| [**GetTenantApplicationTilesAsync**](ApplicationsApi.md#gettenantapplicationtilesasync) | **GET** /tenants/{tenantId}/applicationtiles | Retrieves a list of tenant application tiles |
| [**GetTenantApplicationsAsync**](ApplicationsApi.md#gettenantapplicationsasync) | **GET** /tenants/{tenantId}/applications | Retrieves a list of applications that belong to the current tenant. |

<a id="gettenantapplicationprofilebyidasync"></a>
# **GetTenantApplicationProfileByIdAsync**
> ApplicationApiApplicationV2ApplicationProfileResponse GetTenantApplicationProfileByIdAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific application associated to a tenant using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantApplicationProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific application associated to a tenant using its primary key
                ApplicationApiApplicationV2ApplicationProfileResponse result = apiInstance.GetTenantApplicationProfileByIdAsync(tenantId, applicationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific application associated to a tenant using its primary key
    ApiResponse<ApplicationApiApplicationV2ApplicationProfileResponse> response = apiInstance.GetTenantApplicationProfileByIdAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationProfileResponse**](ApplicationApiApplicationV2ApplicationProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant&#39;s application returned |  -  |
| **404** | Tenant&#39;s application not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your tenant&#39;s application right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantapplicationtilesasync"></a>
# **GetTenantApplicationTilesAsync**
> EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTilesResponseWithUserApplicationLicense GetTenantApplicationTilesAsync (string tenantId, int? pageIndex = null, int? pageSize = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenant application tiles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantApplicationTilesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 100;  // int? |  (optional)  (default to 100)
            var orderBy = "\"applicationName ASC\"";  // string? |  (optional)  (default to "applicationName ASC")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenant application tiles
                EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTilesResponseWithUserApplicationLicense result = apiInstance.GetTenantApplicationTilesAsync(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationTilesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationTilesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenant application tiles
    ApiResponse<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTilesResponseWithUserApplicationLicense> response = apiInstance.GetTenantApplicationTilesAsyncWithHttpInfo(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationTilesAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **pageSize** | **int?** |  | [optional] [default to 100] |
| **orderBy** | **string?** |  | [optional] [default to &quot;applicationName ASC&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTilesResponseWithUserApplicationLicense**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesApplicationTilesResponseWithUserApplicationLicense.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant application tiles returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of tenant application tiles right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantapplicationsasync"></a>
# **GetTenantApplicationsAsync**
> ApplicationApiApplicationV2ApplicationListResponse GetTenantApplicationsAsync (string tenantId, int? pageIndex = null, int? pageSize = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of applications that belong to the current tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantApplicationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var filter = "filter_example";  // string? |  (optional) 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of applications that belong to the current tenant.
                ApplicationApiApplicationV2ApplicationListResponse result = apiInstance.GetTenantApplicationsAsync(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of applications that belong to the current tenant.
    ApiResponse<ApplicationApiApplicationV2ApplicationListResponse> response = apiInstance.GetTenantApplicationsAsyncWithHttpInfo(tenantId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.GetTenantApplicationsAsyncWithHttpInfo: " + e.Message);
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
| **orderBy** | **string?** |  | [optional]  |
| **filter** | **string?** |  | [optional]  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationListResponse**](ApplicationApiApplicationV2ApplicationListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant applications returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of tenant applications right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

