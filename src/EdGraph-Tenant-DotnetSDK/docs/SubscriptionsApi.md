# EdGraph.Tenant.Client.Api.SubscriptionsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTenantSubscriptionAsync**](SubscriptionsApi.md#createtenantsubscriptionasync) | **POST** /tenants/{tenantId}/subscriptions | Creates a new subscription |
| [**GetAllTenantSubscriptionApplications**](SubscriptionsApi.md#getalltenantsubscriptionapplications) | **GET** /tenants/{tenantId}/subscriptions/applications | Retrieves a list of applications available for subscription. |
| [**GetAllTenantSubscriptionsAsync**](SubscriptionsApi.md#getalltenantsubscriptionsasync) | **GET** /tenants/{tenantId}/subscriptions | Retrieves a list of subscriptions associated to this tenant |
| [**GetTenantSubscriptionProfileByIdAsync**](SubscriptionsApi.md#gettenantsubscriptionprofilebyidasync) | **GET** /tenants/{tenantId}/subscriptions/{subscriptionId} | Retrieves a subscription |
| [**UpdateTenantSubscriptionAsync**](SubscriptionsApi.md#updatetenantsubscriptionasync) | **PUT** /tenants/{tenantId}/subscriptions/{subscriptionId} | Updates a subscription |

<a id="createtenantsubscriptionasync"></a>
# **CreateTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionCreatedResponse CreateTenantSubscriptionAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateSubscriptionRequest? tenantApiTenantV1CreateSubscriptionRequest = null)

Creates a new subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateSubscriptionRequest = new TenantApiTenantV1CreateSubscriptionRequest?(); // TenantApiTenantV1CreateSubscriptionRequest? |  (optional) 

            try
            {
                // Creates a new subscription
                TenantApiTenantV1SubscriptionCreatedResponse result = apiInstance.CreateTenantSubscriptionAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new subscription
    ApiResponse<TenantApiTenantV1SubscriptionCreatedResponse> response = apiInstance.CreateTenantSubscriptionAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.CreateTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
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

[**TenantApiTenantV1SubscriptionCreatedResponse**](TenantApiTenantV1SubscriptionCreatedResponse.md)

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
            config.BasePath = "https://api.edgraph.dev/tenant";
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
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantsubscriptionsasync"></a>
# **GetAllTenantSubscriptionsAsync**
> EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel GetAllTenantSubscriptionsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of subscriptions associated to this tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetAllTenantSubscriptionsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
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
                // Retrieves a list of subscriptions associated to this tenant
                EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel result = apiInstance.GetAllTenantSubscriptionsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptionsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantSubscriptionsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of subscriptions associated to this tenant
    ApiResponse<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionListResponseDtoPaginatedItemsViewModel> response = apiInstance.GetAllTenantSubscriptionsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetAllTenantSubscriptionsAsyncWithHttpInfo: " + e.Message);
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
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantsubscriptionprofilebyidasync"></a>
# **GetTenantSubscriptionProfileByIdAsync**
> EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto GetTenantSubscriptionProfileByIdAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null)

Retrieves a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class GetTenantSubscriptionProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a subscription
                EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto result = apiInstance.GetTenantSubscriptionProfileByIdAsync(tenantId, subscriptionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetTenantSubscriptionProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantSubscriptionProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a subscription
    ApiResponse<EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsResponsesSubscriptionProfileResponseDto> response = apiInstance.GetTenantSubscriptionProfileByIdAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetTenantSubscriptionProfileByIdAsyncWithHttpInfo: " + e.Message);
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
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantsubscriptionasync"></a>
# **UpdateTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionUpdatedResponse UpdateTenantSubscriptionAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateSubscriptionRequest? tenantApiTenantV1UpdateSubscriptionRequest = null)

Updates a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
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
                // Updates a subscription
                TenantApiTenantV1SubscriptionUpdatedResponse result = apiInstance.UpdateTenantSubscriptionAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a subscription
    ApiResponse<TenantApiTenantV1SubscriptionUpdatedResponse> response = apiInstance.UpdateTenantSubscriptionAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.UpdateTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
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

[**TenantApiTenantV1SubscriptionUpdatedResponse**](TenantApiTenantV1SubscriptionUpdatedResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

