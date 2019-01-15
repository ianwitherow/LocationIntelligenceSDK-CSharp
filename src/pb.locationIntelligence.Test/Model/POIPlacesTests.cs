/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.0.0
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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Model;
using pb.locationIntelligence.Client;
using System.Reflection;

namespace pb.locationIntelligence.Test
{
    /// <summary>
    ///  Class for testing POIPlaces
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class POIPlacesTests
    {
        // TODO uncomment below to declare an instance variable for POIPlaces
        //private POIPlaces instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of POIPlaces
            //instance = new POIPlaces();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of POIPlaces
        /// </summary>
        [Test]
        public void POIPlacesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" POIPlaces
            //Assert.IsInstanceOfType<POIPlaces> (instance, "variable 'instance' is a POIPlaces");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'BrandName'
        /// </summary>
        [Test]
        public void BrandNameTest()
        {
            // TODO unit test for the property 'BrandName'
        }
        /// <summary>
        /// Test the property 'TradeName'
        /// </summary>
        [Test]
        public void TradeNameTest()
        {
            // TODO unit test for the property 'TradeName'
        }
        /// <summary>
        /// Test the property 'FranchiseName'
        /// </summary>
        [Test]
        public void FranchiseNameTest()
        {
            // TODO unit test for the property 'FranchiseName'
        }
        /// <summary>
        /// Test the property 'Open24Hours'
        /// </summary>
        [Test]
        public void Open24HoursTest()
        {
            // TODO unit test for the property 'Open24Hours'
        }
        /// <summary>
        /// Test the property 'Distance'
        /// </summary>
        [Test]
        public void DistanceTest()
        {
            // TODO unit test for the property 'Distance'
        }
        /// <summary>
        /// Test the property 'RelevanceScore'
        /// </summary>
        [Test]
        public void RelevanceScoreTest()
        {
            // TODO unit test for the property 'RelevanceScore'
        }
        /// <summary>
        /// Test the property 'ContactDetails'
        /// </summary>
        [Test]
        public void ContactDetailsTest()
        {
            // TODO unit test for the property 'ContactDetails'
        }
        /// <summary>
        /// Test the property 'PoiClassification'
        /// </summary>
        [Test]
        public void PoiClassificationTest()
        {
            // TODO unit test for the property 'PoiClassification'
        }
        /// <summary>
        /// Test the property 'SalesVolume'
        /// </summary>
        [Test]
        public void SalesVolumeTest()
        {
            // TODO unit test for the property 'SalesVolume'
        }
        /// <summary>
        /// Test the property 'EmployeeCount'
        /// </summary>
        [Test]
        public void EmployeeCountTest()
        {
            // TODO unit test for the property 'EmployeeCount'
        }
        /// <summary>
        /// Test the property 'YearStart'
        /// </summary>
        [Test]
        public void YearStartTest()
        {
            // TODO unit test for the property 'YearStart'
        }
        /// <summary>
        /// Test the property 'GoodsAgentCode'
        /// </summary>
        [Test]
        public void GoodsAgentCodeTest()
        {
            // TODO unit test for the property 'GoodsAgentCode'
        }
        /// <summary>
        /// Test the property 'GoodsAgentCodeDescription'
        /// </summary>
        [Test]
        public void GoodsAgentCodeDescriptionTest()
        {
            // TODO unit test for the property 'GoodsAgentCodeDescription'
        }
        /// <summary>
        /// Test the property 'LegalStatusCode'
        /// </summary>
        [Test]
        public void LegalStatusCodeTest()
        {
            // TODO unit test for the property 'LegalStatusCode'
        }
        /// <summary>
        /// Test the property 'OrganizationStatusCode'
        /// </summary>
        [Test]
        public void OrganizationStatusCodeTest()
        {
            // TODO unit test for the property 'OrganizationStatusCode'
        }
        /// <summary>
        /// Test the property 'OrganizationStatusCodeDescription'
        /// </summary>
        [Test]
        public void OrganizationStatusCodeDescriptionTest()
        {
            // TODO unit test for the property 'OrganizationStatusCodeDescription'
        }
        /// <summary>
        /// Test the property 'SubsidaryIndicator'
        /// </summary>
        [Test]
        public void SubsidaryIndicatorTest()
        {
            // TODO unit test for the property 'SubsidaryIndicator'
        }
        /// <summary>
        /// Test the property 'SubsidaryIndicatorDescription'
        /// </summary>
        [Test]
        public void SubsidaryIndicatorDescriptionTest()
        {
            // TODO unit test for the property 'SubsidaryIndicatorDescription'
        }
        /// <summary>
        /// Test the property 'ParentBusiness'
        /// </summary>
        [Test]
        public void ParentBusinessTest()
        {
            // TODO unit test for the property 'ParentBusiness'
        }
        /// <summary>
        /// Test the property 'DomesticUltimateBusiness'
        /// </summary>
        [Test]
        public void DomesticUltimateBusinessTest()
        {
            // TODO unit test for the property 'DomesticUltimateBusiness'
        }
        /// <summary>
        /// Test the property 'GlobalUltimateIndicator'
        /// </summary>
        [Test]
        public void GlobalUltimateIndicatorTest()
        {
            // TODO unit test for the property 'GlobalUltimateIndicator'
        }
        /// <summary>
        /// Test the property 'GlobalUltimateBusiness'
        /// </summary>
        [Test]
        public void GlobalUltimateBusinessTest()
        {
            // TODO unit test for the property 'GlobalUltimateBusiness'
        }
        /// <summary>
        /// Test the property 'FamilyMembers'
        /// </summary>
        [Test]
        public void FamilyMembersTest()
        {
            // TODO unit test for the property 'FamilyMembers'
        }
        /// <summary>
        /// Test the property 'HierarchyCode'
        /// </summary>
        [Test]
        public void HierarchyCodeTest()
        {
            // TODO unit test for the property 'HierarchyCode'
        }
        /// <summary>
        /// Test the property 'TickerSymbol'
        /// </summary>
        [Test]
        public void TickerSymbolTest()
        {
            // TODO unit test for the property 'TickerSymbol'
        }
        /// <summary>
        /// Test the property 'ExchangeName'
        /// </summary>
        [Test]
        public void ExchangeNameTest()
        {
            // TODO unit test for the property 'ExchangeName'
        }
        /// <summary>
        /// Test the property 'Geometry'
        /// </summary>
        [Test]
        public void GeometryTest()
        {
            // TODO unit test for the property 'Geometry'
        }

    }

}