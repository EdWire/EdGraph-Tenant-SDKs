# EdGraph.Tenant.Client.Api.InvitationsApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTenantInvitation**](InvitationsApi.md#deletetenantinvitation) | **DELETE** /tenants/{tenantId}/invitations/{invitationId} | Delete a tenant invitation matching the primary key |
| [**GetAllTenantInvitations**](InvitationsApi.md#getalltenantinvitations) | **GET** /tenants/{tenantId}/invitations | Retrieves a list of tenant invitations |
| [**GetTenantInvitationById**](InvitationsApi.md#gettenantinvitationbyid) | **GET** /tenants/{tenantId}/invitations/{invitationId} | Retrieves a specific tenant invitation using its primary key |
| [**SendTenantInvitation**](InvitationsApi.md#sendtenantinvitation) | **POST** /tenants/{tenantId}/invitations | Send an invitation |

<a id="deletetenantinvitation"></a>
# **DeleteTenantInvitation**
> void DeleteTenantInvitation (string tenantId, string invitationId, string? apiVersion = null, string? xVersion = null)

Delete a tenant invitation matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class DeleteTenantInvitationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvitationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var invitationId = "invitationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Delete a tenant invitation matching the primary key
                apiInstance.DeleteTenantInvitation(tenantId, invitationId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvitationsApi.DeleteTenantInvitation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantInvitationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a tenant invitation matching the primary key
    apiInstance.DeleteTenantInvitationWithHttpInfo(tenantId, invitationId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvitationsApi.DeleteTenantInvitationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **invitationId** | **string** |  |  |
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
| **204** | Tenant invitation deleted |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t delete your tenant invitation right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantinvitations"></a>
# **GetAllTenantInvitations**
> IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel GetAllTenantInvitations (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenant invitations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantInvitationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvitationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenant invitations
                IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantInvitations(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvitationsApi.GetAllTenantInvitations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantInvitationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenant invitations
    ApiResponse<IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantInvitationsWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvitationsApi.GetAllTenantInvitationsWithHttpInfo: " + e.Message);
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

[**IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel**](IdentityApiInvitationV1InvitationListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant invitations returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of tenant invitations right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantinvitationbyid"></a>
# **GetTenantInvitationById**
> IdentityApiInvitationV1InvitationResponse GetTenantInvitationById (string tenantId, string invitationId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific tenant invitation using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantInvitationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvitationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var invitationId = "invitationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific tenant invitation using its primary key
                IdentityApiInvitationV1InvitationResponse result = apiInstance.GetTenantInvitationById(tenantId, invitationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvitationsApi.GetTenantInvitationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantInvitationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tenant invitation using its primary key
    ApiResponse<IdentityApiInvitationV1InvitationResponse> response = apiInstance.GetTenantInvitationByIdWithHttpInfo(tenantId, invitationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvitationsApi.GetTenantInvitationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **invitationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**IdentityApiInvitationV1InvitationResponse**](IdentityApiInvitationV1InvitationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant invitation returned |  -  |
| **404** | Tenant invitation not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your tenant invitation right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendtenantinvitation"></a>
# **SendTenantInvitation**
> void SendTenantInvitation (string tenantId, string? apiVersion = null, string? xVersion = null, IdentityApiInvitationV1SendInvitationRequest? identityApiInvitationV1SendInvitationRequest = null)

Send an invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class SendTenantInvitationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvitationsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiInvitationV1SendInvitationRequest = new IdentityApiInvitationV1SendInvitationRequest?(); // IdentityApiInvitationV1SendInvitationRequest? |  (optional) 

            try
            {
                // Send an invitation
                apiInstance.SendTenantInvitation(tenantId, apiVersion, xVersion, identityApiInvitationV1SendInvitationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvitationsApi.SendTenantInvitation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTenantInvitationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an invitation
    apiInstance.SendTenantInvitationWithHttpInfo(tenantId, apiVersion, xVersion, identityApiInvitationV1SendInvitationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvitationsApi.SendTenantInvitationWithHttpInfo: " + e.Message);
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
| **identityApiInvitationV1SendInvitationRequest** | [**IdentityApiInvitationV1SendInvitationRequest?**](IdentityApiInvitationV1SendInvitationRequest?.md) |  | [optional]  |

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
| **202** | Invitation sent |  -  |
| **400** | invitation has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t send your invitation right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

