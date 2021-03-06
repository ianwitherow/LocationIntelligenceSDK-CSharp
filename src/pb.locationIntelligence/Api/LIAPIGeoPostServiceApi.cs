/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace pb.locationIntelligence.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILIAPIGeoPostServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Carrier Route By Address.
        /// </summary>
        /// <remarks>
        /// Get United States Postal Service (USPS) carrier route data for the requested address
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>CarrierRouteResponse</returns>
        CarrierRouteResponse GetCarrierRoutesByAddress (string address, string includeGeometry = null);

        /// <summary>
        /// Carrier Route By Address.
        /// </summary>
        /// <remarks>
        /// Get United States Postal Service (USPS) carrier route data for the requested address
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>ApiResponse of CarrierRouteResponse</returns>
        ApiResponse<CarrierRouteResponse> GetCarrierRoutesByAddressWithHttpInfo (string address, string includeGeometry = null);
        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <remarks>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CarrierRouteResponseList</returns>
        CarrierRouteResponseList GetCarrierRoutesByAddressBatch (CarrierRouteAddressRequest body = null);

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <remarks>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CarrierRouteResponseList</returns>
        ApiResponse<CarrierRouteResponseList> GetCarrierRoutesByAddressBatchWithHttpInfo (CarrierRouteAddressRequest body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Carrier Route By Address.
        /// </summary>
        /// <remarks>
        /// Get United States Postal Service (USPS) carrier route data for the requested address
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>Task of CarrierRouteResponse</returns>
        System.Threading.Tasks.Task<CarrierRouteResponse> GetCarrierRoutesByAddressAsync (string address, string includeGeometry = null);

        /// <summary>
        /// Carrier Route By Address.
        /// </summary>
        /// <remarks>
        /// Get United States Postal Service (USPS) carrier route data for the requested address
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>Task of ApiResponse (CarrierRouteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CarrierRouteResponse>> GetCarrierRoutesByAddressAsyncWithHttpInfo (string address, string includeGeometry = null);
        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <remarks>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CarrierRouteResponseList</returns>
        System.Threading.Tasks.Task<CarrierRouteResponseList> GetCarrierRoutesByAddressBatchAsync (CarrierRouteAddressRequest body = null);

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <remarks>
        /// Gets GeoPost Carrier Routes for Multiple Addresses
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CarrierRouteResponseList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CarrierRouteResponseList>> GetCarrierRoutesByAddressBatchAsyncWithHttpInfo (CarrierRouteAddressRequest body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LIAPIGeoPostServiceApi : ILIAPIGeoPostServiceApi
    {
        private pb.locationIntelligence.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LIAPIGeoPostServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LIAPIGeoPostServiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = pb.locationIntelligence.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LIAPIGeoPostServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LIAPIGeoPostServiceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = pb.locationIntelligence.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public pb.locationIntelligence.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Carrier Route By Address. Get United States Postal Service (USPS) carrier route data for the requested address
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>CarrierRouteResponse</returns>
        public CarrierRouteResponse GetCarrierRoutesByAddress (string address, string includeGeometry = null)
        {
             ApiResponse<CarrierRouteResponse> localVarResponse = GetCarrierRoutesByAddressWithHttpInfo(address, includeGeometry);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Carrier Route By Address. Get United States Postal Service (USPS) carrier route data for the requested address
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>ApiResponse of CarrierRouteResponse</returns>
        public ApiResponse< CarrierRouteResponse > GetCarrierRoutesByAddressWithHttpInfo (string address, string includeGeometry = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling LIAPIGeoPostServiceApi->GetCarrierRoutesByAddress");

            var localVarPath = "/geopost/v1/carrierroute/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (includeGeometry != null) localVarQueryParams.Add("includeGeometry", Configuration.ApiClient.ParameterToString(includeGeometry)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCarrierRoutesByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CarrierRouteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (CarrierRouteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CarrierRouteResponse)));
            
        }

        /// <summary>
        /// Carrier Route By Address. Get United States Postal Service (USPS) carrier route data for the requested address
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>Task of CarrierRouteResponse</returns>
        public async System.Threading.Tasks.Task<CarrierRouteResponse> GetCarrierRoutesByAddressAsync (string address, string includeGeometry = null)
        {
             ApiResponse<CarrierRouteResponse> localVarResponse = await GetCarrierRoutesByAddressAsyncWithHttpInfo(address, includeGeometry);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Carrier Route By Address. Get United States Postal Service (USPS) carrier route data for the requested address
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text</param>
        /// <param name="includeGeometry">Y or N (default is Y) - if it is Y, then geometry will be part of response (optional)</param>
        /// <returns>Task of ApiResponse (CarrierRouteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CarrierRouteResponse>> GetCarrierRoutesByAddressAsyncWithHttpInfo (string address, string includeGeometry = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling LIAPIGeoPostServiceApi->GetCarrierRoutesByAddress");

            var localVarPath = "/geopost/v1/carrierroute/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (includeGeometry != null) localVarQueryParams.Add("includeGeometry", Configuration.ApiClient.ParameterToString(includeGeometry)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCarrierRoutesByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CarrierRouteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (CarrierRouteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CarrierRouteResponse)));
            
        }

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CarrierRouteResponseList</returns>
        public CarrierRouteResponseList GetCarrierRoutesByAddressBatch (CarrierRouteAddressRequest body = null)
        {
             ApiResponse<CarrierRouteResponseList> localVarResponse = GetCarrierRoutesByAddressBatchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CarrierRouteResponseList</returns>
        public ApiResponse< CarrierRouteResponseList > GetCarrierRoutesByAddressBatchWithHttpInfo (CarrierRouteAddressRequest body = null)
        {

            var localVarPath = "/geopost/v1/carrierroute/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCarrierRoutesByAddressBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CarrierRouteResponseList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (CarrierRouteResponseList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CarrierRouteResponseList)));
            
        }

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CarrierRouteResponseList</returns>
        public async System.Threading.Tasks.Task<CarrierRouteResponseList> GetCarrierRoutesByAddressBatchAsync (CarrierRouteAddressRequest body = null)
        {
             ApiResponse<CarrierRouteResponseList> localVarResponse = await GetCarrierRoutesByAddressBatchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets GeoPost Carrier Routes for Multiple Addresses Gets GeoPost Carrier Routes for Multiple Addresses
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CarrierRouteResponseList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CarrierRouteResponseList>> GetCarrierRoutesByAddressBatchAsyncWithHttpInfo (CarrierRouteAddressRequest body = null)
        {

            var localVarPath = "/geopost/v1/carrierroute/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCarrierRoutesByAddressBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CarrierRouteResponseList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (CarrierRouteResponseList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CarrierRouteResponseList)));
            
        }

    }
}
