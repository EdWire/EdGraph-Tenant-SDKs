# EdGraph.Tenant.Client.Api.IdentityAPIClientsApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTenantApiClient**](IdentityAPIClientsApi.md#createtenantapiclient) | **POST** /tenants/{tenantId}/identity/apiclients | Creates a new tenant OpenId api client |
| [**DeleteTenantApiClient**](IdentityAPIClientsApi.md#deletetenantapiclient) | **DELETE** /tenants/{tenantId}/identity/apiclients/{clientId} | Delete a tenant&#39;s OpenId api client matching the primary key |
| [**GetAllTenantApiClients**](IdentityAPIClientsApi.md#getalltenantapiclients) | **GET** /tenants/{tenantId}/identity/apiclients | Retrieves  a list of OpenId api clients associated to this tenant |
| [**GetTenantApiClientProfileById**](IdentityAPIClientsApi.md#gettenantapiclientprofilebyid) | **GET** /tenants/{tenantId}/identity/apiclients/{clientId} | Retrieves the OpenId api client associated to this tenant |
| [**RegenerateTenantApiClientSecret**](IdentityAPIClientsApi.md#regeneratetenantapiclientsecret) | **POST** /tenants/{tenantId}/identity/apiclients/{clientId}/regeneratesecret | Creates a tenant&#39;s OpenId client secret matching the primary key |
| [**UpdateTenantApiClient**](IdentityAPIClientsApi.md#updatetenantapiclient) | **PUT** /tenants/{tenantId}/identity/apiclients/{clientId} | Updates a tenant&#39;s OpenId api client matching the primary key |

<a id="createtenantapiclient"></a>
# **CreateTenantApiClient**
> void CreateTenantApiClient (string tenantId, string? apiVersion = null, string? xVersion = null, IdentityApiApiClientV1CreateApiClientRequest? identityApiApiClientV1CreateApiClientRequest = null)

Creates a new tenant OpenId api client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateTenantApiClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiApiClientV1CreateApiClientRequest = new IdentityApiApiClientV1CreateApiClientRequest?(); // IdentityApiApiClientV1CreateApiClientRequest? |  (optional) 

            try
            {
                // Creates a new tenant OpenId api client
                apiInstance.CreateTenantApiClient(tenantId, apiVersion, xVersion, identityApiApiClientV1CreateApiClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.CreateTenantApiClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantApiClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new tenant OpenId api client
    apiInstance.CreateTenantApiClientWithHttpInfo(tenantId, apiVersion, xVersion, identityApiApiClientV1CreateApiClientRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.CreateTenantApiClientWithHttpInfo: " + e.Message);
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
| **identityApiApiClientV1CreateApiClientRequest** | [**IdentityApiApiClientV1CreateApiClientRequest?**](IdentityApiApiClientV1CreateApiClientRequest?.md) |  | [optional]  |

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
| **202** | Tenant&#39;s OpenId client created |  -  |
| **400** | Tenant&#39;s OpenId client has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create your tenant&#39;s OpenId client right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantapiclient"></a>
# **DeleteTenantApiClient**
> void DeleteTenantApiClient (string tenantId, string clientId, string? apiVersion = null, string? xVersion = null)

Delete a tenant's OpenId api client matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class DeleteTenantApiClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var clientId = "clientId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Delete a tenant's OpenId api client matching the primary key
                apiInstance.DeleteTenantApiClient(tenantId, clientId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.DeleteTenantApiClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantApiClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a tenant's OpenId api client matching the primary key
    apiInstance.DeleteTenantApiClientWithHttpInfo(tenantId, clientId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.DeleteTenantApiClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **clientId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Tenant&#39;s OpenId client deleted |  -  |
| **400** | Tenant&#39;s OpenId client has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t delete your tenant&#39;s OpenId client right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantapiclients"></a>
# **GetAllTenantApiClients**
> IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel GetAllTenantApiClients (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves  a list of OpenId api clients associated to this tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantApiClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves  a list of OpenId api clients associated to this tenant
                IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantApiClients(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.GetAllTenantApiClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantApiClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves  a list of OpenId api clients associated to this tenant
    ApiResponse<IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantApiClientsWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.GetAllTenantApiClientsWithHttpInfo: " + e.Message);
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

[**IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel**](IdentityApiApiClientV1ApiClientPaginatedItemsResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant OpenId api client returned |  -  |
| **404** | Not Found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your list of tenant application&#39;s OpenId api client right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantapiclientprofilebyid"></a>
# **GetTenantApiClientProfileById**
> IdentityApiApiClientV1ApiClientProfileResponse GetTenantApiClientProfileById (string tenantId, string clientId, string? apiVersion = null, string? xVersion = null)

Retrieves the OpenId api client associated to this tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantApiClientProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var clientId = "clientId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves the OpenId api client associated to this tenant
                IdentityApiApiClientV1ApiClientProfileResponse result = apiInstance.GetTenantApiClientProfileById(tenantId, clientId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.GetTenantApiClientProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApiClientProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the OpenId api client associated to this tenant
    ApiResponse<IdentityApiApiClientV1ApiClientProfileResponse> response = apiInstance.GetTenantApiClientProfileByIdWithHttpInfo(tenantId, clientId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.GetTenantApiClientProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **clientId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**IdentityApiApiClientV1ApiClientProfileResponse**](IdentityApiApiClientV1ApiClientProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant OpenId api client returned |  -  |
| **404** | Tenant OpenId api client not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your tenant application&#39;s OpenId api client right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="regeneratetenantapiclientsecret"></a>
# **RegenerateTenantApiClientSecret**
> void RegenerateTenantApiClientSecret (string tenantId, string clientId, string? apiVersion = null, string? xVersion = null, IdentityApiApiClientV1RegenerateApiClientSecretRequest? identityApiApiClientV1RegenerateApiClientSecretRequest = null)

Creates a tenant's OpenId client secret matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class RegenerateTenantApiClientSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var clientId = "clientId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiApiClientV1RegenerateApiClientSecretRequest = new IdentityApiApiClientV1RegenerateApiClientSecretRequest?(); // IdentityApiApiClientV1RegenerateApiClientSecretRequest? |  (optional) 

            try
            {
                // Creates a tenant's OpenId client secret matching the primary key
                apiInstance.RegenerateTenantApiClientSecret(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1RegenerateApiClientSecretRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.RegenerateTenantApiClientSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegenerateTenantApiClientSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a tenant's OpenId client secret matching the primary key
    apiInstance.RegenerateTenantApiClientSecretWithHttpInfo(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1RegenerateApiClientSecretRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.RegenerateTenantApiClientSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **clientId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiApiClientV1RegenerateApiClientSecretRequest** | [**IdentityApiApiClientV1RegenerateApiClientSecretRequest?**](IdentityApiApiClientV1RegenerateApiClientSecretRequest?.md) |  | [optional]  |

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
| **202** | Tenant&#39;s OpenId client secret created/updated |  -  |
| **400** | Tenant&#39;s OpenId client secret has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create/update your tenant&#39;s OpenId client secret right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantapiclient"></a>
# **UpdateTenantApiClient**
> void UpdateTenantApiClient (string tenantId, string clientId, string? apiVersion = null, string? xVersion = null, IdentityApiApiClientV1UpdateApiClientRequest? identityApiApiClientV1UpdateApiClientRequest = null)

Updates a tenant's OpenId api client matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateTenantApiClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityAPIClientsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var clientId = "clientId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiApiClientV1UpdateApiClientRequest = new IdentityApiApiClientV1UpdateApiClientRequest?(); // IdentityApiApiClientV1UpdateApiClientRequest? |  (optional) 

            try
            {
                // Updates a tenant's OpenId api client matching the primary key
                apiInstance.UpdateTenantApiClient(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1UpdateApiClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityAPIClientsApi.UpdateTenantApiClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantApiClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a tenant's OpenId api client matching the primary key
    apiInstance.UpdateTenantApiClientWithHttpInfo(tenantId, clientId, apiVersion, xVersion, identityApiApiClientV1UpdateApiClientRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityAPIClientsApi.UpdateTenantApiClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **clientId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiApiClientV1UpdateApiClientRequest** | [**IdentityApiApiClientV1UpdateApiClientRequest?**](IdentityApiApiClientV1UpdateApiClientRequest?.md) |  | [optional]  |

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
| **202** | Tenant&#39;s OpenId client created/updated |  -  |
| **400** | Tenant&#39;s OpenId client has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create/update your tenant&#39;s OpenId client right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

