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
    /// End
    /// </summary>
    [DataContract]
    public partial class End :  IEquatable<End>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="End" /> class.
        /// </summary>
        /// <param name="Year">Year.</param>
        /// <param name="Month">Month.</param>
        /// <param name="Day">Day.</param>
        public End(int? Year = null, int? Month = null, int? Day = null)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class End {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
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
            return this.Equals(obj as End);
        }

        /// <summary>
        /// Returns true if End instances are equal
        /// </summary>
        /// <param name="other">Instance of End to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(End other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) && 
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) && 
                (
                    this.Day == other.Day ||
                    this.Day != null &&
                    this.Day.Equals(other.Day)
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
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();
                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();
                if (this.Day != null)
                    hash = hash * 59 + this.Day.GetHashCode();
                return hash;
            }
        }
    }

}
