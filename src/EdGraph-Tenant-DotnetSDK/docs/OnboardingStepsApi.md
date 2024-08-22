# EdGraph.Tenant.Client.Api.OnboardingStepsApi

All URIs are relative to *https://api.dev.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOnboardingStepAsync**](OnboardingStepsApi.md#createonboardingstepasync) | **POST** /tenants/{tenantId}/onboardingsteps | Creates an Onboarding Step. |
| [**UpdateOnboardingStepAsync**](OnboardingStepsApi.md#updateonboardingstepasync) | **PUT** /tenants/{tenantId}/onboardingsteps/{stepNumber} | Updates the status of an Onboarding Step. |

<a id="createonboardingstepasync"></a>
# **CreateOnboardingStepAsync**
> TenantApiTenantV1TenantUpdatedResponse CreateOnboardingStepAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateOnboardingStepRequest? tenantApiTenantV1CreateOnboardingStepRequest = null)

Creates an Onboarding Step.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class CreateOnboardingStepAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingStepsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateOnboardingStepRequest = new TenantApiTenantV1CreateOnboardingStepRequest?(); // TenantApiTenantV1CreateOnboardingStepRequest? |  (optional) 

            try
            {
                // Creates an Onboarding Step.
                TenantApiTenantV1TenantUpdatedResponse result = apiInstance.CreateOnboardingStepAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateOnboardingStepRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnboardingStepsApi.CreateOnboardingStepAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOnboardingStepAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an Onboarding Step.
    ApiResponse<TenantApiTenantV1TenantUpdatedResponse> response = apiInstance.CreateOnboardingStepAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateOnboardingStepRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnboardingStepsApi.CreateOnboardingStepAsyncWithHttpInfo: " + e.Message);
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
| **tenantApiTenantV1CreateOnboardingStepRequest** | [**TenantApiTenantV1CreateOnboardingStepRequest?**](TenantApiTenantV1CreateOnboardingStepRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1TenantUpdatedResponse**](TenantApiTenantV1TenantUpdatedResponse.md)

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

<a id="updateonboardingstepasync"></a>
# **UpdateOnboardingStepAsync**
> TenantApiTenantV1TenantUpdatedResponse UpdateOnboardingStepAsync (string tenantId, int stepNumber, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateOnboardingStepRequest? tenantApiTenantV1UpdateOnboardingStepRequest = null)

Updates the status of an Onboarding Step.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Tenant.Client.Api;
using EdGraph.Tenant.Client.Client;
using EdGraph.Tenant.Client.Model;

namespace Example
{
    public class UpdateOnboardingStepAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingStepsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepNumber = 56;  // int | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateOnboardingStepRequest = new TenantApiTenantV1UpdateOnboardingStepRequest?(); // TenantApiTenantV1UpdateOnboardingStepRequest? |  (optional) 

            try
            {
                // Updates the status of an Onboarding Step.
                TenantApiTenantV1TenantUpdatedResponse result = apiInstance.UpdateOnboardingStepAsync(tenantId, stepNumber, apiVersion, xVersion, tenantApiTenantV1UpdateOnboardingStepRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnboardingStepsApi.UpdateOnboardingStepAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOnboardingStepAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the status of an Onboarding Step.
    ApiResponse<TenantApiTenantV1TenantUpdatedResponse> response = apiInstance.UpdateOnboardingStepAsyncWithHttpInfo(tenantId, stepNumber, apiVersion, xVersion, tenantApiTenantV1UpdateOnboardingStepRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnboardingStepsApi.UpdateOnboardingStepAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepNumber** | **int** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1UpdateOnboardingStepRequest** | [**TenantApiTenantV1UpdateOnboardingStepRequest?**](TenantApiTenantV1UpdateOnboardingStepRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1TenantUpdatedResponse**](TenantApiTenantV1TenantUpdatedResponse.md)

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

