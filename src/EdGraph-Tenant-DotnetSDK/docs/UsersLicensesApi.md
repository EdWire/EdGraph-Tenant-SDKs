# EdGraph.Tenant.Client.Api.UsersLicensesApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignLicenseTenantUser**](UsersLicensesApi.md#assignlicensetenantuser) | **POST** /tenants/{tenantId}/users/{userId}/licenses/assignlicense | Assigns a license to a tenant user matching the primary key |
| [**AssignLicenseTenantUserBulk**](UsersLicensesApi.md#assignlicensetenantuserbulk) | **POST** /tenants/{tenantId}/users/{userId}/licenses/assignlicensebulk | Assigns a license to a tenant user matching the primary key |
| [**GetAllTenantUserApplicationLicenses**](UsersLicensesApi.md#getalltenantuserapplicationlicenses) | **GET** /tenants/{tenantId}/users/{userId}/licenses | Retrieves a list of tenant users licenses |
| [**RevokeLicenseTenantUser**](UsersLicensesApi.md#revokelicensetenantuser) | **POST** /tenants/{tenantId}/users/{userId}/licenses/revokelicense | Revokes a license to a tenant user matching the primary key |
| [**RevokeLicenseTenantUserBulk**](UsersLicensesApi.md#revokelicensetenantuserbulk) | **POST** /tenants/{tenantId}/users/{userId}/licenses/revokelicensebulk | Revokes a license to a tenant user matching the primary key |

<a id="assignlicensetenantuser"></a>
# **AssignLicenseTenantUser**
> void AssignLicenseTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1AssignLicenseRequest? identityApiUserV1AssignLicenseRequest = null)

Assigns a license to a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class AssignLicenseTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersLicensesApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1AssignLicenseRequest = new IdentityApiUserV1AssignLicenseRequest?(); // IdentityApiUserV1AssignLicenseRequest? |  (optional) 

            try
            {
                // Assigns a license to a tenant user matching the primary key
                apiInstance.AssignLicenseTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1AssignLicenseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersLicensesApi.AssignLicenseTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignLicenseTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assigns a license to a tenant user matching the primary key
    apiInstance.AssignLicenseTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1AssignLicenseRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersLicensesApi.AssignLicenseTenantUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1AssignLicenseRequest** | [**IdentityApiUserV1AssignLicenseRequest?**](IdentityApiUserV1AssignLicenseRequest?.md) |  | [optional]  |

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
| **202** | Tenant user assigned a license |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t assigned a license to your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assignlicensetenantuserbulk"></a>
# **AssignLicenseTenantUserBulk**
> void AssignLicenseTenantUserBulk (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1AssignLicenseBulkRequest? identityApiUserV1AssignLicenseBulkRequest = null)

Assigns a license to a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class AssignLicenseTenantUserBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersLicensesApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1AssignLicenseBulkRequest = new IdentityApiUserV1AssignLicenseBulkRequest?(); // IdentityApiUserV1AssignLicenseBulkRequest? |  (optional) 

            try
            {
                // Assigns a license to a tenant user matching the primary key
                apiInstance.AssignLicenseTenantUserBulk(tenantId, userId, apiVersion, xVersion, identityApiUserV1AssignLicenseBulkRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersLicensesApi.AssignLicenseTenantUserBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignLicenseTenantUserBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assigns a license to a tenant user matching the primary key
    apiInstance.AssignLicenseTenantUserBulkWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1AssignLicenseBulkRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersLicensesApi.AssignLicenseTenantUserBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1AssignLicenseBulkRequest** | [**IdentityApiUserV1AssignLicenseBulkRequest?**](IdentityApiUserV1AssignLicenseBulkRequest?.md) |  | [optional]  |

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
| **202** | Tenant user assigned a license |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t assigned a license to your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantuserapplicationlicenses"></a>
# **GetAllTenantUserApplicationLicenses**
> EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicensePaginatedItemsViewModel GetAllTenantUserApplicationLicenses (string tenantId, string userId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenant users licenses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantUserApplicationLicensesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersLicensesApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenant users licenses
                EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicensePaginatedItemsViewModel result = apiInstance.GetAllTenantUserApplicationLicenses(tenantId, userId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersLicensesApi.GetAllTenantUserApplicationLicenses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantUserApplicationLicensesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenant users licenses
    ApiResponse<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicensePaginatedItemsViewModel> response = apiInstance.GetAllTenantUserApplicationLicensesWithHttpInfo(tenantId, userId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersLicensesApi.GetAllTenantUserApplicationLicensesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **userId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicensePaginatedItemsViewModel**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserLicensePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant users licenses returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of tenant users licenses right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="revokelicensetenantuser"></a>
# **RevokeLicenseTenantUser**
> void RevokeLicenseTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1RevokeLicenseRequest? identityApiUserV1RevokeLicenseRequest = null)

Revokes a license to a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class RevokeLicenseTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersLicensesApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1RevokeLicenseRequest = new IdentityApiUserV1RevokeLicenseRequest?(); // IdentityApiUserV1RevokeLicenseRequest? |  (optional) 

            try
            {
                // Revokes a license to a tenant user matching the primary key
                apiInstance.RevokeLicenseTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1RevokeLicenseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersLicensesApi.RevokeLicenseTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeLicenseTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revokes a license to a tenant user matching the primary key
    apiInstance.RevokeLicenseTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1RevokeLicenseRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersLicensesApi.RevokeLicenseTenantUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1RevokeLicenseRequest** | [**IdentityApiUserV1RevokeLicenseRequest?**](IdentityApiUserV1RevokeLicenseRequest?.md) |  | [optional]  |

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
| **202** | Tenant user revokes a license |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t revoke a license to your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="revokelicensetenantuserbulk"></a>
# **RevokeLicenseTenantUserBulk**
> void RevokeLicenseTenantUserBulk (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1RevokeLicenseBulkRequest? identityApiUserV1RevokeLicenseBulkRequest = null)

Revokes a license to a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class RevokeLicenseTenantUserBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersLicensesApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1RevokeLicenseBulkRequest = new IdentityApiUserV1RevokeLicenseBulkRequest?(); // IdentityApiUserV1RevokeLicenseBulkRequest? |  (optional) 

            try
            {
                // Revokes a license to a tenant user matching the primary key
                apiInstance.RevokeLicenseTenantUserBulk(tenantId, userId, apiVersion, xVersion, identityApiUserV1RevokeLicenseBulkRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersLicensesApi.RevokeLicenseTenantUserBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeLicenseTenantUserBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revokes a license to a tenant user matching the primary key
    apiInstance.RevokeLicenseTenantUserBulkWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1RevokeLicenseBulkRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersLicensesApi.RevokeLicenseTenantUserBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1RevokeLicenseBulkRequest** | [**IdentityApiUserV1RevokeLicenseBulkRequest?**](IdentityApiUserV1RevokeLicenseBulkRequest?.md) |  | [optional]  |

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
| **202** | Tenant user revokes a license |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t revoke a license to your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

