# EdGraph.Tenant.Client.Api.UsersApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateTenantUser**](UsersApi.md#activatetenantuser) | **POST** /tenants/{tenantId}/users/{userId}/activate | Activate a Tenant user matching the primary key |
| [**CreateTenantLocalUser**](UsersApi.md#createtenantlocaluser) | **POST** /tenants/{tenantId}/users/addlocaluser | Creates a new tenant local user |
| [**DeactivateTenantUser**](UsersApi.md#deactivatetenantuser) | **POST** /tenants/{tenantId}/users/{userId}/deactivate | Deactivate a Tenant user matching the primary key |
| [**DeleteTenantUser**](UsersApi.md#deletetenantuser) | **DELETE** /tenants/{tenantId}/users/{userId} | Delete a tenant user matching the primary key |
| [**GetAllTenantUsers**](UsersApi.md#getalltenantusers) | **GET** /tenants/{tenantId}/users | Retrieves a list of tenant users |
| [**GetTenantUserProfileById**](UsersApi.md#gettenantuserprofilebyid) | **GET** /tenants/{tenantId}/users/{userId} | Retrieves a specific tenant user using its primary key |
| [**ResetPasswordTenantUser**](UsersApi.md#resetpasswordtenantuser) | **PUT** /tenants/{tenantId}/users/{userId}/resetpassword | Reset a tenant user password |
| [**UpdateTenantUser**](UsersApi.md#updatetenantuser) | **PUT** /tenants/{tenantId}/users/{userId} | Creates or Updates a tenant user matching the primary key |

<a id="activatetenantuser"></a>
# **ActivateTenantUser**
> void ActivateTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1ActivateUserRequest? identityApiUserV1ActivateUserRequest = null)

Activate a Tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class ActivateTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1ActivateUserRequest = new IdentityApiUserV1ActivateUserRequest?(); // IdentityApiUserV1ActivateUserRequest? |  (optional) 

            try
            {
                // Activate a Tenant user matching the primary key
                apiInstance.ActivateTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1ActivateUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ActivateTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a Tenant user matching the primary key
    apiInstance.ActivateTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1ActivateUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ActivateTenantUserWithHttpInfo: " + e.Message);
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
| **identityApiUserV1ActivateUserRequest** | [**IdentityApiUserV1ActivateUserRequest?**](IdentityApiUserV1ActivateUserRequest?.md) |  | [optional]  |

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
| **202** | Tenant user activated |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t activate your Tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtenantlocaluser"></a>
# **CreateTenantLocalUser**
> void CreateTenantLocalUser (string tenantId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1CreateLocalUserRequest? identityApiUserV1CreateLocalUserRequest = null)

Creates a new tenant local user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateTenantLocalUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1CreateLocalUserRequest = new IdentityApiUserV1CreateLocalUserRequest?(); // IdentityApiUserV1CreateLocalUserRequest? |  (optional) 

            try
            {
                // Creates a new tenant local user
                apiInstance.CreateTenantLocalUser(tenantId, apiVersion, xVersion, identityApiUserV1CreateLocalUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateTenantLocalUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantLocalUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new tenant local user
    apiInstance.CreateTenantLocalUserWithHttpInfo(tenantId, apiVersion, xVersion, identityApiUserV1CreateLocalUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.CreateTenantLocalUserWithHttpInfo: " + e.Message);
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
| **identityApiUserV1CreateLocalUserRequest** | [**IdentityApiUserV1CreateLocalUserRequest?**](IdentityApiUserV1CreateLocalUserRequest?.md) |  | [optional]  |

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
| **202** | Tenant local user created |  -  |
| **400** | Tenant local user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create your tenant local user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deactivatetenantuser"></a>
# **DeactivateTenantUser**
> void DeactivateTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1DeactivateUserRequest? identityApiUserV1DeactivateUserRequest = null)

Deactivate a Tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class DeactivateTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1DeactivateUserRequest = new IdentityApiUserV1DeactivateUserRequest?(); // IdentityApiUserV1DeactivateUserRequest? |  (optional) 

            try
            {
                // Deactivate a Tenant user matching the primary key
                apiInstance.DeactivateTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1DeactivateUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeactivateTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate a Tenant user matching the primary key
    apiInstance.DeactivateTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1DeactivateUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeactivateTenantUserWithHttpInfo: " + e.Message);
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
| **identityApiUserV1DeactivateUserRequest** | [**IdentityApiUserV1DeactivateUserRequest?**](IdentityApiUserV1DeactivateUserRequest?.md) |  | [optional]  |

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
| **202** | Tenant user deactivated |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t deactivate your Tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantuser"></a>
# **DeleteTenantUser**
> void DeleteTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null)

Delete a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class DeleteTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Delete a tenant user matching the primary key
                apiInstance.DeleteTenantUser(tenantId, userId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a tenant user matching the primary key
    apiInstance.DeleteTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteTenantUserWithHttpInfo: " + e.Message);
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
| **204** | Tenant user deleted |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t delete your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantusers"></a>
# **GetAllTenantUsers**
> EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserListResponseWithApplicationLicensePaginatedItemsViewModel GetAllTenantUsers (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenant users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenant users
                EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserListResponseWithApplicationLicensePaginatedItemsViewModel result = apiInstance.GetAllTenantUsers(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAllTenantUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenant users
    ApiResponse<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserListResponseWithApplicationLicensePaginatedItemsViewModel> response = apiInstance.GetAllTenantUsersWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetAllTenantUsersWithHttpInfo: " + e.Message);
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

[**EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserListResponseWithApplicationLicensePaginatedItemsViewModel**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserListResponseWithApplicationLicensePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant users returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of tenant users right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantuserprofilebyid"></a>
# **GetTenantUserProfileById**
> EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserProfileResponseWithApplicationLicense GetTenantUserProfileById (string tenantId, string userId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific tenant user using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantUserProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific tenant user using its primary key
                EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserProfileResponseWithApplicationLicense result = apiInstance.GetTenantUserProfileById(tenantId, userId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetTenantUserProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantUserProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tenant user using its primary key
    ApiResponse<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserProfileResponseWithApplicationLicense> response = apiInstance.GetTenantUserProfileByIdWithHttpInfo(tenantId, userId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetTenantUserProfileByIdWithHttpInfo: " + e.Message);
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

### Return type

[**EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserProfileResponseWithApplicationLicense**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesUserProfileResponseWithApplicationLicense.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant user returned |  -  |
| **404** | Tenant user not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resetpasswordtenantuser"></a>
# **ResetPasswordTenantUser**
> void ResetPasswordTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1ResetPasswordRequest? identityApiUserV1ResetPasswordRequest = null)

Reset a tenant user password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class ResetPasswordTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1ResetPasswordRequest = new IdentityApiUserV1ResetPasswordRequest?(); // IdentityApiUserV1ResetPasswordRequest? |  (optional) 

            try
            {
                // Reset a tenant user password
                apiInstance.ResetPasswordTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1ResetPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResetPasswordTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetPasswordTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset a tenant user password
    apiInstance.ResetPasswordTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1ResetPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ResetPasswordTenantUserWithHttpInfo: " + e.Message);
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
| **identityApiUserV1ResetPasswordRequest** | [**IdentityApiUserV1ResetPasswordRequest?**](IdentityApiUserV1ResetPasswordRequest?.md) |  | [optional]  |

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
| **202** | Tenant user password updated |  -  |
| **400** | Tenant user password request has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t reset your tenant user password right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantuser"></a>
# **UpdateTenantUser**
> void UpdateTenantUser (string tenantId, string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1UpdateUserRequest? identityApiUserV1UpdateUserRequest = null)

Creates or Updates a tenant user matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateTenantUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1UpdateUserRequest = new IdentityApiUserV1UpdateUserRequest?(); // IdentityApiUserV1UpdateUserRequest? |  (optional) 

            try
            {
                // Creates or Updates a tenant user matching the primary key
                apiInstance.UpdateTenantUser(tenantId, userId, apiVersion, xVersion, identityApiUserV1UpdateUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateTenantUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or Updates a tenant user matching the primary key
    apiInstance.UpdateTenantUserWithHttpInfo(tenantId, userId, apiVersion, xVersion, identityApiUserV1UpdateUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateTenantUserWithHttpInfo: " + e.Message);
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
| **identityApiUserV1UpdateUserRequest** | [**IdentityApiUserV1UpdateUserRequest?**](IdentityApiUserV1UpdateUserRequest?.md) |  | [optional]  |

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
| **202** | Tenant user created/updated |  -  |
| **400** | Tenant user has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create/update your tenant user right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

