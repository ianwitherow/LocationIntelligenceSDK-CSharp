/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.7.0
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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pb.locationIntelligence.Model
{
    /// <summary>
    /// FireEvent
    /// </summary>
    [DataContract]
    public partial class FireEvent :  IEquatable<FireEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireEvent" /> class.
        /// </summary>
        /// <param name="FireStartDate">FireStartDate.</param>
        /// <param name="FireEndDate">FireEndDate.</param>
        /// <param name="FireName">FireName.</param>
        /// <param name="Area">Area.</param>
        /// <param name="Agency">Agency.</param>
        public FireEvent(string FireStartDate = null, string FireEndDate = null, string FireName = null, Area Area = null, string Agency = null)
        {
            this.FireStartDate = FireStartDate;
            this.FireEndDate = FireEndDate;
            this.FireName = FireName;
            this.Area = Area;
            this.Agency = Agency;
        }
        
        /// <summary>
        /// Gets or Sets FireStartDate
        /// </summary>
        [DataMember(Name="fireStartDate", EmitDefaultValue=false)]
        public string FireStartDate { get; set; }
        /// <summary>
        /// Gets or Sets FireEndDate
        /// </summary>
        [DataMember(Name="fireEndDate", EmitDefaultValue=false)]
        public string FireEndDate { get; set; }
        /// <summary>
        /// Gets or Sets FireName
        /// </summary>
        [DataMember(Name="fireName", EmitDefaultValue=false)]
        public string FireName { get; set; }
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public Area Area { get; set; }
        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireEvent {\n");
            sb.Append("  FireStartDate: ").Append(FireStartDate).Append("\n");
            sb.Append("  FireEndDate: ").Append(FireEndDate).Append("\n");
            sb.Append("  FireName: ").Append(FireName).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FireEvent);
        }

        /// <summary>
        /// Returns true if FireEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of FireEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FireStartDate == other.FireStartDate ||
                    this.FireStartDate != null &&
                    this.FireStartDate.Equals(other.FireStartDate)
                ) && 
                (
                    this.FireEndDate == other.FireEndDate ||
                    this.FireEndDate != null &&
                    this.FireEndDate.Equals(other.FireEndDate)
                ) && 
                (
                    this.FireName == other.FireName ||
                    this.FireName != null &&
                    this.FireName.Equals(other.FireName)
                ) && 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
                ) && 
                (
                    this.Agency == other.Agency ||
                    this.Agency != null &&
                    this.Agency.Equals(other.Agency)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FireStartDate != null)
                    hash = hash * 59 + this.FireStartDate.GetHashCode();
                if (this.FireEndDate != null)
                    hash = hash * 59 + this.FireEndDate.GetHashCode();
                if (this.FireName != null)
                    hash = hash * 59 + this.FireName.GetHashCode();
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                if (this.Agency != null)
                    hash = hash * 59 + this.Agency.GetHashCode();
                return hash;
            }
        }
    }

}