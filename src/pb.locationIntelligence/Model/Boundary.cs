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
    /// Boundary
    /// </summary>
    [DataContract]
    public partial class Boundary :  IEquatable<Boundary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundary" /> class.
        /// </summary>
        /// <param name="BoundaryId">BoundaryId.</param>
        /// <param name="BoundaryType">BoundaryType.</param>
        /// <param name="BoundaryRef">BoundaryRef.</param>
        public Boundary(string BoundaryId = null, string BoundaryType = null, string BoundaryRef = null)
        {
            this.BoundaryId = BoundaryId;
            this.BoundaryType = BoundaryType;
            this.BoundaryRef = BoundaryRef;
        }
        
        /// <summary>
        /// Gets or Sets BoundaryId
        /// </summary>
        [DataMember(Name="boundaryId", EmitDefaultValue=false)]
        public string BoundaryId { get; set; }
        /// <summary>
        /// Gets or Sets BoundaryType
        /// </summary>
        [DataMember(Name="boundaryType", EmitDefaultValue=false)]
        public string BoundaryType { get; set; }
        /// <summary>
        /// Gets or Sets BoundaryRef
        /// </summary>
        [DataMember(Name="boundaryRef", EmitDefaultValue=false)]
        public string BoundaryRef { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boundary {\n");
            sb.Append("  BoundaryId: ").Append(BoundaryId).Append("\n");
            sb.Append("  BoundaryType: ").Append(BoundaryType).Append("\n");
            sb.Append("  BoundaryRef: ").Append(BoundaryRef).Append("\n");
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
            return this.Equals(obj as Boundary);
        }

        /// <summary>
        /// Returns true if Boundary instances are equal
        /// </summary>
        /// <param name="other">Instance of Boundary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boundary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BoundaryId == other.BoundaryId ||
                    this.BoundaryId != null &&
                    this.BoundaryId.Equals(other.BoundaryId)
                ) && 
                (
                    this.BoundaryType == other.BoundaryType ||
                    this.BoundaryType != null &&
                    this.BoundaryType.Equals(other.BoundaryType)
                ) && 
                (
                    this.BoundaryRef == other.BoundaryRef ||
                    this.BoundaryRef != null &&
                    this.BoundaryRef.Equals(other.BoundaryRef)
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
                if (this.BoundaryId != null)
                    hash = hash * 59 + this.BoundaryId.GetHashCode();
                if (this.BoundaryType != null)
                    hash = hash * 59 + this.BoundaryType.GetHashCode();
                if (this.BoundaryRef != null)
                    hash = hash * 59 + this.BoundaryRef.GetHashCode();
                return hash;
            }
        }
    }

}
