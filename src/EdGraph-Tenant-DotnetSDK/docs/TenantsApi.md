# EdGraph.Tenant.Client.Api.TenantsApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTenantById**](TenantsApi.md#gettenantbyid) | **GET** /tenants/{tenantId} | Retrieves a specific tenant using its primary key |
| [**UpdateTenant**](TenantsApi.md#updatetenant) | **POST** /tenants/{tenantId} | Update a new tenant with only new IdentityProviders |

<a id="gettenantbyid"></a>
# **GetTenantById**
> TenantApiTenantV1TenantProfileResponse GetTenantById (string tenantId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific tenant using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific tenant using its primary key
                TenantApiTenantV1TenantProfileResponse result = apiInstance.GetTenantById(tenantId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tenant using its primary key
    ApiResponse<TenantApiTenantV1TenantProfileResponse> response = apiInstance.GetTenantByIdWithHttpInfo(tenantId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantByIdWithHttpInfo: " + e.Message);
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

### Return type

[**TenantApiTenantV1TenantProfileResponse**](TenantApiTenantV1TenantProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant returned |  -  |
| **404** | Tenant not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your tenant right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenant"></a>
# **UpdateTenant**
> void UpdateTenant (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateTenantRequest? tenantApiTenantV1UpdateTenantRequest = null)

Update a new tenant with only new IdentityProviders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateTenantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateTenantRequest = new TenantApiTenantV1UpdateTenantRequest?(); // TenantApiTenantV1UpdateTenantRequest? |  (optional) 

            try
            {
                // Update a new tenant with only new IdentityProviders
                apiInstance.UpdateTenant(tenantId, apiVersion, xVersion, tenantApiTenantV1UpdateTenantRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateTenant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a new tenant with only new IdentityProviders
    apiInstance.UpdateTenantWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1UpdateTenantRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.UpdateTenantWithHttpInfo: " + e.Message);
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
| **tenantApiTenantV1UpdateTenantRequest** | [**TenantApiTenantV1UpdateTenantRequest?**](TenantApiTenantV1UpdateTenantRequest?.md) |  | [optional]  |

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
| **202** | Update tenant request accepted |  -  |
| **400** | Update Tenant request has missing/invalid values |  -  |
| **500** | Oops! Can&#39;t update your tenant right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

