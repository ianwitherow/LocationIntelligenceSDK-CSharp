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
    /// SpeedLimit
    /// </summary>
    [DataContract]
    public partial class SpeedLimit :  IEquatable<SpeedLimit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedLimit" /> class.
        /// </summary>
        /// <param name="MaxSpeed">MaxSpeed.</param>
        /// <param name="SpeedUnit">SpeedUnit.</param>
        /// <param name="SpeedVerification">SpeedVerification.</param>
        /// <param name="AmPeakAvgSpeed">AmPeakAvgSpeed.</param>
        /// <param name="PmPeakAvgSpeed">PmPeakAvgSpeed.</param>
        /// <param name="OffPeakAvgSpeed">OffPeakAvgSpeed.</param>
        /// <param name="NightAvgSpeed">NightAvgSpeed.</param>
        /// <param name="WeekAvgSpeed">WeekAvgSpeed.</param>
        /// <param name="Road">Road.</param>
        public SpeedLimit(string MaxSpeed = null, string SpeedUnit = null, string SpeedVerification = null, string AmPeakAvgSpeed = null, string PmPeakAvgSpeed = null, string OffPeakAvgSpeed = null, string NightAvgSpeed = null, string WeekAvgSpeed = null, SpeedRoad Road = null)
        {
            this.MaxSpeed = MaxSpeed;
            this.SpeedUnit = SpeedUnit;
            this.SpeedVerification = SpeedVerification;
            this.AmPeakAvgSpeed = AmPeakAvgSpeed;
            this.PmPeakAvgSpeed = PmPeakAvgSpeed;
            this.OffPeakAvgSpeed = OffPeakAvgSpeed;
            this.NightAvgSpeed = NightAvgSpeed;
            this.WeekAvgSpeed = WeekAvgSpeed;
            this.Road = Road;
        }
        
        /// <summary>
        /// Gets or Sets MaxSpeed
        /// </summary>
        [DataMember(Name="maxSpeed", EmitDefaultValue=false)]
        public string MaxSpeed { get; set; }
        /// <summary>
        /// Gets or Sets SpeedUnit
        /// </summary>
        [DataMember(Name="speedUnit", EmitDefaultValue=false)]
        public string SpeedUnit { get; set; }
        /// <summary>
        /// Gets or Sets SpeedVerification
        /// </summary>
        [DataMember(Name="speedVerification", EmitDefaultValue=false)]
        public string SpeedVerification { get; set; }
        /// <summary>
        /// Gets or Sets AmPeakAvgSpeed
        /// </summary>
        [DataMember(Name="amPeakAvgSpeed", EmitDefaultValue=false)]
        public string AmPeakAvgSpeed { get; set; }
        /// <summary>
        /// Gets or Sets PmPeakAvgSpeed
        /// </summary>
        [DataMember(Name="pmPeakAvgSpeed", EmitDefaultValue=false)]
        public string PmPeakAvgSpeed { get; set; }
        /// <summary>
        /// Gets or Sets OffPeakAvgSpeed
        /// </summary>
        [DataMember(Name="offPeakAvgSpeed", EmitDefaultValue=false)]
        public string OffPeakAvgSpeed { get; set; }
        /// <summary>
        /// Gets or Sets NightAvgSpeed
        /// </summary>
        [DataMember(Name="nightAvgSpeed", EmitDefaultValue=false)]
        public string NightAvgSpeed { get; set; }
        /// <summary>
        /// Gets or Sets WeekAvgSpeed
        /// </summary>
        [DataMember(Name="weekAvgSpeed", EmitDefaultValue=false)]
        public string WeekAvgSpeed { get; set; }
        /// <summary>
        /// Gets or Sets Road
        /// </summary>
        [DataMember(Name="road", EmitDefaultValue=false)]
        public SpeedRoad Road { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeedLimit {\n");
            sb.Append("  MaxSpeed: ").Append(MaxSpeed).Append("\n");
            sb.Append("  SpeedUnit: ").Append(SpeedUnit).Append("\n");
            sb.Append("  SpeedVerification: ").Append(SpeedVerification).Append("\n");
            sb.Append("  AmPeakAvgSpeed: ").Append(AmPeakAvgSpeed).Append("\n");
            sb.Append("  PmPeakAvgSpeed: ").Append(PmPeakAvgSpeed).Append("\n");
            sb.Append("  OffPeakAvgSpeed: ").Append(OffPeakAvgSpeed).Append("\n");
            sb.Append("  NightAvgSpeed: ").Append(NightAvgSpeed).Append("\n");
            sb.Append("  WeekAvgSpeed: ").Append(WeekAvgSpeed).Append("\n");
            sb.Append("  Road: ").Append(Road).Append("\n");
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
            return this.Equals(obj as SpeedLimit);
        }

        /// <summary>
        /// Returns true if SpeedLimit instances are equal
        /// </summary>
        /// <param name="other">Instance of SpeedLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeedLimit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaxSpeed == other.MaxSpeed ||
                    this.MaxSpeed != null &&
                    this.MaxSpeed.Equals(other.MaxSpeed)
                ) && 
                (
                    this.SpeedUnit == other.SpeedUnit ||
                    this.SpeedUnit != null &&
                    this.SpeedUnit.Equals(other.SpeedUnit)
                ) && 
                (
                    this.SpeedVerification == other.SpeedVerification ||
                    this.SpeedVerification != null &&
                    this.SpeedVerification.Equals(other.SpeedVerification)
                ) && 
                (
                    this.AmPeakAvgSpeed == other.AmPeakAvgSpeed ||
                    this.AmPeakAvgSpeed != null &&
                    this.AmPeakAvgSpeed.Equals(other.AmPeakAvgSpeed)
                ) && 
                (
                    this.PmPeakAvgSpeed == other.PmPeakAvgSpeed ||
                    this.PmPeakAvgSpeed != null &&
                    this.PmPeakAvgSpeed.Equals(other.PmPeakAvgSpeed)
                ) && 
                (
                    this.OffPeakAvgSpeed == other.OffPeakAvgSpeed ||
                    this.OffPeakAvgSpeed != null &&
                    this.OffPeakAvgSpeed.Equals(other.OffPeakAvgSpeed)
                ) && 
                (
                    this.NightAvgSpeed == other.NightAvgSpeed ||
                    this.NightAvgSpeed != null &&
                    this.NightAvgSpeed.Equals(other.NightAvgSpeed)
                ) && 
                (
                    this.WeekAvgSpeed == other.WeekAvgSpeed ||
                    this.WeekAvgSpeed != null &&
                    this.WeekAvgSpeed.Equals(other.WeekAvgSpeed)
                ) && 
                (
                    this.Road == other.Road ||
                    this.Road != null &&
                    this.Road.Equals(other.Road)
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
                if (this.MaxSpeed != null)
                    hash = hash * 59 + this.MaxSpeed.GetHashCode();
                if (this.SpeedUnit != null)
                    hash = hash * 59 + this.SpeedUnit.GetHashCode();
                if (this.SpeedVerification != null)
                    hash = hash * 59 + this.SpeedVerification.GetHashCode();
                if (this.AmPeakAvgSpeed != null)
                    hash = hash * 59 + this.AmPeakAvgSpeed.GetHashCode();
                if (this.PmPeakAvgSpeed != null)
                    hash = hash * 59 + this.PmPeakAvgSpeed.GetHashCode();
                if (this.OffPeakAvgSpeed != null)
                    hash = hash * 59 + this.OffPeakAvgSpeed.GetHashCode();
                if (this.NightAvgSpeed != null)
                    hash = hash * 59 + this.NightAvgSpeed.GetHashCode();
                if (this.WeekAvgSpeed != null)
                    hash = hash * 59 + this.WeekAvgSpeed.GetHashCode();
                if (this.Road != null)
                    hash = hash * 59 + this.Road.GetHashCode();
                return hash;
            }
        }
    }

}
