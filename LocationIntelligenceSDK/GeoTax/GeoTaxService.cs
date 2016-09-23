#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.geotax.model;
using System;


namespace com.pb.locationintelligence.geotax
{




    /// <summary>
    /// This service provides tax details w.r.t requested Address or Latitude-Longitude.
    /// </summary>
    public interface GeoTaxService {


        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        event EventHandler<WebResponseEventArgs<TaxRateResponse>> LiAPIRequestFinishedEvent;
        event EventHandler<WebResponseEventArgs<TaxResponseList>> LiAPIGEoTaxBatchRequestFinishedEvent;


        #region Http GetMethod Calls

        /// <summary>
        /// Accepts taxRateTypeId , latitude and longitude information and gets the GeoTax Rate information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        TaxRateResponse getGeoTaxRateByLocation(String taxType, Double latitude, Double longitude);




        /// <summary>
        /// Accepts taxRateTypeId , latitude and longitude information and gets the GeoTax Rate information in asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        void getGeoTaxRateByLocationAsync(String taxType, Double latitude, Double longitude);


        /// <summary>
        /// Accepts taxRateTypeId  and address information and gets the GeoTax Rate information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        TaxRateResponse getGeoTaxRateByAddress(String taxType, String address);





        /// <summary>
        /// Accepts taxRateTypeId  and address information and gets the GeoTax Rate information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        void getGeoTaxRateByAddressAsync(String taxType, String address);


        /// <summary>
        /// Accepts taxRateTypeId , latitude , longitude and purchaseAmount information and gets the GeoTax  information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        TaxRateResponse getGeoTaxByLocation(String taxType, Double latitude, Double longitude, Double purchaseAmount);




        /// <summary>
        /// Accepts taxRateTypeId , latitude , longitude and purchaseAmount information and gets the GeoTax  information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        void getGeoTaxByLocationAsync(String taxType, Double latitude, Double longitude, Double purchaseAmount);


        /// <summary>
        /// Accepts taxRateTypeId , address  and purchaseAmount information and gets the GeoTax  information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        TaxRateResponse getGeoTaxByAddress(String taxType, String address, Double purchaseAmount);

        /// <summary>
        /// Accepts taxRateTypeId , address  and purchaseAmount information and gets the GeoTax  information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        void getGeoTaxByAddressAsync(String taxType, String address, Double purchaseAmount);



        #endregion

        

        #region Http Post GeoTax_Batch

        /// <summary>
        /// Gets the geo tax rate batch by location.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        TaxResponseList getGeoTaxRateBatchByLocation(String taxRateTypeId, TaxRateLocationRequest request) ;


        /// <summary>
        /// Gets the geo tax rate by batch address.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
         TaxResponseList getGeoTaxRateByBatchAddress(String taxRateTypeId, TaxRateAddressRequest request) ;


        /// <summary>
        /// Gets the geo tax by batch location.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
         TaxResponseList getGeoTaxByBatchLocation(String taxRateTypeId, TaxLocationRequest request) ;


        /// <summary>
        /// Gets the geo tax by batch address.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
         TaxResponseList getGeoTaxByBatchAddress(String taxRateTypeId, TaxAddressRequest request) ;


        /// <summary>
        /// Gets the geo tax rate batch by location.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <param name="requestObserver">The request observer.</param>
        void getGeoTaxRateBatchByLocationAsync(String taxRateTypeId, TaxRateLocationRequest request);


        /// <summary>
        /// Gets the geo tax rate by batch address.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <param name="requestObserver">The request observer.</param>
        void getGeoTaxRateByBatchAddressAsync(String taxRateTypeId, TaxRateAddressRequest request);


        /// <summary>
        /// Gets the geo tax by batch location.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <param name="requestObserver">The request observer.</param>
        void getGeoTaxByBatchLocationAsync(String taxRateTypeId, TaxLocationRequest request );


        /// <summary>
        /// Gets the geo tax by batch address.
        /// </summary>
        /// <param name="taxRateTypeId">The tax rate type identifier.</param>
        /// <param name="request">The request.</param>
        /// <param name="requestObserver">The request observer.</param>
        void getGeoTaxByBatchAddressAsync(String taxRateTypeId, TaxAddressRequest request );

        #endregion
    }
}