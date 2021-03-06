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
    /// AHJPlusPSAPResponse
    /// </summary>
    [DataContract]
    public partial class AHJPlusPSAPResponse :  IEquatable<AHJPlusPSAPResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AHJPlusPSAPResponse" /> class.
        /// </summary>
        /// <param name="Ahjs">Ahjs.</param>
        /// <param name="Psap">Psap.</param>
        /// <param name="Count">Count.</param>
        public AHJPlusPSAPResponse(AHJList Ahjs = null, PSAPResponse Psap = null, int? Count = null)
        {
            this.Ahjs = Ahjs;
            this.Psap = Psap;
            this.Count = Count;
        }
        
        /// <summary>
        /// Gets or Sets Ahjs
        /// </summary>
        [DataMember(Name="ahjs", EmitDefaultValue=false)]
        public AHJList Ahjs { get; set; }
        /// <summary>
        /// Gets or Sets Psap
        /// </summary>
        [DataMember(Name="psap", EmitDefaultValue=false)]
        public PSAPResponse Psap { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AHJPlusPSAPResponse {\n");
            sb.Append("  Ahjs: ").Append(Ahjs).Append("\n");
            sb.Append("  Psap: ").Append(Psap).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AHJPlusPSAPResponse);
        }

        /// <summary>
        /// Returns true if AHJPlusPSAPResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AHJPlusPSAPResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AHJPlusPSAPResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ahjs == other.Ahjs ||
                    this.Ahjs != null &&
                    this.Ahjs.Equals(other.Ahjs)
                ) && 
                (
                    this.Psap == other.Psap ||
                    this.Psap != null &&
                    this.Psap.Equals(other.Psap)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.Ahjs != null)
                    hash = hash * 59 + this.Ahjs.GetHashCode();
                if (this.Psap != null)
                    hash = hash * 59 + this.Psap.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }
    }

}
