# pb.locationIntelligence.Api.LIAPIGeoIdentityServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIdentityByAddress**](LIAPIGeoIdentityServiceApi.md#getidentitybyaddress) | **GET** /geoidentity/v1/identity/byaddress | Gets GeoIdentityResponse
[**GetIdentityByEmail**](LIAPIGeoIdentityServiceApi.md#getidentitybyemail) | **GET** /geoidentity/v1/identity/byemail | Gets Identity
[**GetIdentityByPBKey**](LIAPIGeoIdentityServiceApi.md#getidentitybypbkey) | **GET** /geoidentity/v1/identity/bypbkey | Gets GeoIdentityResponse


<a name="getidentitybyaddress"></a>
# **GetIdentityByAddress**
> GeoIdentityResponse GetIdentityByAddress (string address, string givenName = null, string familyName = null, string confidence = null, string maxCandidates = null, string includeNeighborhoodDetails = null)

Gets GeoIdentityResponse

Gets GeoIdentityResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetIdentityByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoIdentityServiceApi();
            var address = address_example;  // string | free form address text
            var givenName = givenName_example;  // string | This filters all the associated identities of address by given Name (optional) 
            var familyName = familyName_example;  // string | This filters all the associated identities of address by family Name (optional) 
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 
            var maxCandidates = maxCandidates_example;  // string | Number of identities returned in response (optional) 
            var includeNeighborhoodDetails = includeNeighborhoodDetails_example;  // string | Whether to include neighborhood details in the response or not. Default is Y (optional) 

            try
            {
                // Gets GeoIdentityResponse
                GeoIdentityResponse result = apiInstance.GetIdentityByAddress(address, givenName, familyName, confidence, maxCandidates, includeNeighborhoodDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoIdentityServiceApi.GetIdentityByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **givenName** | **string**| This filters all the associated identities of address by given Name | [optional] 
 **familyName** | **string**| This filters all the associated identities of address by family Name | [optional] 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 
 **maxCandidates** | **string**| Number of identities returned in response | [optional] 
 **includeNeighborhoodDetails** | **string**| Whether to include neighborhood details in the response or not. Default is Y | [optional] 

### Return type

[**GeoIdentityResponse**](GeoIdentityResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitybyemail"></a>
# **GetIdentityByEmail**
> Identity GetIdentityByEmail (string email, string confidence = null)

Gets Identity

Gets Identity

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetIdentityByEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoIdentityServiceApi();
            var email = email_example;  // string | This specifies the email address
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 

            try
            {
                // Gets Identity
                Identity result = apiInstance.GetIdentityByEmail(email, confidence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoIdentityServiceApi.GetIdentityByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| This specifies the email address | 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 

### Return type

[**Identity**](Identity.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitybypbkey"></a>
# **GetIdentityByPBKey**
> GeoIdentityResponse GetIdentityByPBKey (string pbKey, string givenName = null, string familyName = null, string confidence = null, string maxCandidates = null, string includeNeighborhoodDetails = null)

Gets GeoIdentityResponse

Gets GeoIdentityResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetIdentityByPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoIdentityServiceApi();
            var pbKey = pbKey_example;  // string | PB specific unique key for each address
            var givenName = givenName_example;  // string | This filters all the associated identities of address by given Name (optional) 
            var familyName = familyName_example;  // string | This filters all the associated identities of address by family Name (optional) 
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 
            var maxCandidates = maxCandidates_example;  // string | Number of identities returned in response (optional) 
            var includeNeighborhoodDetails = includeNeighborhoodDetails_example;  // string | Whether to include neighborhood details in the response or not. Default is Y (optional) 

            try
            {
                // Gets GeoIdentityResponse
                GeoIdentityResponse result = apiInstance.GetIdentityByPBKey(pbKey, givenName, familyName, confidence, maxCandidates, includeNeighborhoodDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoIdentityServiceApi.GetIdentityByPBKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbKey** | **string**| PB specific unique key for each address | 
 **givenName** | **string**| This filters all the associated identities of address by given Name | [optional] 
 **familyName** | **string**| This filters all the associated identities of address by family Name | [optional] 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 
 **maxCandidates** | **string**| Number of identities returned in response | [optional] 
 **includeNeighborhoodDetails** | **string**| Whether to include neighborhood details in the response or not. Default is Y | [optional] 

### Return type

[**GeoIdentityResponse**](GeoIdentityResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
