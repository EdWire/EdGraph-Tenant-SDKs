# EdGraph.Tenant.Client.Api.SubscriptionsApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTenantSubscription**](SubscriptionsApi.md#createtenantsubscription) | **POST** /tenants/{tenantId}/subscriptions/create | Creates a new Tenant Subscription |
| [**GetAllTenantSubscriptionApplications**](SubscriptionsApi.md#getalltenantsubscriptionapplications) | **GET** /tenants/{tenantId}/subscriptions/applications | Retrieves a list of applications available for subscription. |
| [**GetAllTenantSubscriptions**](SubscriptionsApi.md#getalltenantsubscriptions) | **GET** /tenants/{tenantId}/subscriptions | Retrieves a list of Tenant Subscriptions |
| [**GetTenantSubscriptionProfileById**](SubscriptionsApi.md#gettenantsubscriptionprofilebyid) | **GET** /tenants/{tenantId}/subscriptions/{subscriptionId} | Retrieves a specific Tenant Subscription using its primary key |
| [**UpdateTenantSubscription**](SubscriptionsApi.md#updatetenantsubscription) | **POST** /tenants/{tenantId}/subscriptions/{subscriptionId}/update | Updates a Tenant Subscription matching the primary key |

<a id="createtenantsubscription"></a>
# **CreateTenantSubscription**
> void CreateTenantSubscription (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateSubscriptionRequest? tenantApiTenantV1CreateSubscriptionRequest = null)

Creates a new Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateTenantSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateSubscriptionRequest = new TenantApiTenantV1CreateSubscriptionRequest?(); // TenantApiTenantV1CreateSubscriptionRequest? |  (optional) 

            try
            {
                // Creates a new Tenant Subscription
                apiInstance.CreateTenantSubscription(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateTenantSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Tenant Subscription
    apiInstance.CreateTenantSubscriptionWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.CreateTenantSubscriptionWithHttpInfo: " + e.Message);
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
| **tenantApiTenantV1CreateSubscriptionRequest** | [**TenantApiTenantV1CreateSubscriptionRequest?**](TenantApiTenantV1CreateSubscriptionRequest?.md) |  | [optional]  |

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
| **202** | Tenant Subscription created |  -  |
| **400** | Tenant Subscription has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create your Tenant Subscription right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantsubscriptionapplications"></a>
# **GetAllTenantSubscriptionApplications**
> ApplicationApiApplicationV2PaginatedItemsResponse GetAllTenantSubscriptionApplications (string tenantId, int? pageIndex = null, int? pageSize = null, string? orderBy = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of applications available for subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantSubscriptionApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of applications available for subscription.
                ApplicationApiApplicationV2PaginatedItemsResponse result = apiInstance.GetAllTenantSubscriptionApplications(tenantId, pageIndex, pageSize, orderBy, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptionApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantSubscriptionApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of applications available for subscription.
    ApiResponse<ApplicationApiApplicationV2PaginatedItemsResponse> response = apiInstance.GetAllTenantSubscriptionApplicationsWithHttpInfo(tenantId, pageIndex, pageSize, orderBy, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptionApplicationsWithHttpInfo: " + e.Message);
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
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2PaginatedItemsResponse**](ApplicationApiApplicationV2PaginatedItemsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of applications |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the resource right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantsubscriptions"></a>
# **GetAllTenantSubscriptions**
> EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel GetAllTenantSubscriptions (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of Tenant Subscriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of Tenant Subscriptions
                EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel result = apiInstance.GetAllTenantSubscriptions(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of Tenant Subscriptions
    ApiResponse<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel> response = apiInstance.GetAllTenantSubscriptionsWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptionsWithHttpInfo: " + e.Message);
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

[**EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel**](EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Tenant Subscriptions returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of Tenant Subscriptions right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantsubscriptionprofilebyid"></a>
# **GetTenantSubscriptionProfileById**
> EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto GetTenantSubscriptionProfileById (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific Tenant Subscription using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantSubscriptionProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific Tenant Subscription using its primary key
                EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto result = apiInstance.GetTenantSubscriptionProfileById(tenantId, subscriptionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetTenantSubscriptionProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantSubscriptionProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific Tenant Subscription using its primary key
    ApiResponse<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto> response = apiInstance.GetTenantSubscriptionProfileByIdWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetTenantSubscriptionProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto**](EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant Subscription returned |  -  |
| **404** | Tenant Subscription not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your Tenant Subscription right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantsubscription"></a>
# **UpdateTenantSubscription**
> void UpdateTenantSubscription (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateSubscriptionRequest? tenantApiTenantV1UpdateSubscriptionRequest = null)

Updates a Tenant Subscription matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateTenantSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateSubscriptionRequest = new TenantApiTenantV1UpdateSubscriptionRequest?(); // TenantApiTenantV1UpdateSubscriptionRequest? |  (optional) 

            try
            {
                // Updates a Tenant Subscription matching the primary key
                apiInstance.UpdateTenantSubscription(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateTenantSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Tenant Subscription matching the primary key
    apiInstance.UpdateTenantSubscriptionWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.UpdateTenantSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1UpdateSubscriptionRequest** | [**TenantApiTenantV1UpdateSubscriptionRequest?**](TenantApiTenantV1UpdateSubscriptionRequest?.md) |  | [optional]  |

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
| **202** | Tenant Subscription updated |  -  |
| **400** | Tenant Subscription has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t update your Tenant Subscription right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

