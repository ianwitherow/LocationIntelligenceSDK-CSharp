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
    /// DemographicsV2
    /// </summary>
    [DataContract]
    public partial class DemographicsV2 :  IEquatable<DemographicsV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DemographicsV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsV2" /> class.
        /// </summary>
        /// <param name="Boundaries">Boundaries (required).</param>
        /// <param name="Themes">Themes (required).</param>
        public DemographicsV2(Boundaries Boundaries = null, DemographicsThemesV2 Themes = null)
        {
            // to ensure "Boundaries" is required (not null)
            if (Boundaries == null)
            {
                throw new InvalidDataException("Boundaries is a required property for DemographicsV2 and cannot be null");
            }
            else
            {
                this.Boundaries = Boundaries;
            }
            // to ensure "Themes" is required (not null)
            if (Themes == null)
            {
                throw new InvalidDataException("Themes is a required property for DemographicsV2 and cannot be null");
            }
            else
            {
                this.Themes = Themes;
            }
        }
        
        /// <summary>
        /// Gets or Sets Boundaries
        /// </summary>
        [DataMember(Name="boundaries", EmitDefaultValue=false)]
        public Boundaries Boundaries { get; set; }
        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public DemographicsThemesV2 Themes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemographicsV2 {\n");
            sb.Append("  Boundaries: ").Append(Boundaries).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
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
            return this.Equals(obj as DemographicsV2);
        }

        /// <summary>
        /// Returns true if DemographicsV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of DemographicsV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DemographicsV2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Boundaries == other.Boundaries ||
                    this.Boundaries != null &&
                    this.Boundaries.Equals(other.Boundaries)
                ) && 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.Equals(other.Themes)
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
                if (this.Boundaries != null)
                    hash = hash * 59 + this.Boundaries.GetHashCode();
                if (this.Themes != null)
                    hash = hash * 59 + this.Themes.GetHashCode();
                return hash;
            }
        }
    }

}
